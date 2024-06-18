using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.ModuloQuestao;

internal class ControladorQuestao : ControladorBase
{
    private readonly IRepositorioMateria repositorioMateria;
    private readonly IRepositorioQuestao repositorioQuestao;
    private readonly IRepositorioTeste repositorioTeste;
    private TabelaQuestaoControl tabelaQuestao;

    public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria,
        IRepositorioTeste repositorioTeste)
    {
        this.repositorioQuestao = repositorioQuestao;
        this.repositorioMateria = repositorioMateria;
        this.repositorioTeste = repositorioTeste;
        AtualizarRodapeQuantidadeRegistros();
    }

    public override string TipoCadastro => "Questões";

    public override string ToolTipAdicionar => "Cadastrar uma nova questão";

    public override string ToolTipEditar => "Editar uma questão já existente";

    public override string ToolTipExcluir => "Excluir uma questão já existente";

    public override void Adicionar()
    {
        if (!PossuiRegistroSuficiente())
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(
                "Não é possível adicionar uma \"Questão\" sem ter uma \"Materia\"!");
            return;
        }

        var telaQuestao =
            new TelaQuestaoForm(repositorioQuestao.SelecionarTodos(), repositorioMateria.SelecionarTodos());

        var resultado = telaQuestao.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoQuestao = telaQuestao.Questao;

        repositorioQuestao.Cadastrar(novoQuestao);

        CarregarQuestoes();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoQuestao.Enunciado}\" foi criado com sucesso!");
    }

    public override void Editar()
    {
        var QuestaoSelecionada = repositorioQuestao.SelecionarPorId(tabelaQuestao.ObterRegistroSelecionado());

        var telaQuestao =
            new TelaQuestaoForm(repositorioQuestao.SelecionarTodos(), repositorioMateria.SelecionarTodos());

        if (QuestaoSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        telaQuestao.Questao = QuestaoSelecionada;

        var resultado = telaQuestao.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var QuestaoEditada = telaQuestao.Questao;

        repositorioQuestao.Editar(QuestaoSelecionada.Id, QuestaoEditada);

        CarregarQuestoes();

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"O registro \"{QuestaoEditada.Enunciado}\" foi editado com sucesso!");
    }

    public override void Excluir()
    {
        var QuestaoSelecionada = repositorioQuestao.SelecionarPorId(tabelaQuestao.ObterRegistroSelecionado());
        if (QuestaoSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (PossuiDependencias(QuestaoSelecionada))
            return;

        var resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{QuestaoSelecionada.Enunciado}\"?"
            , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (resposta != DialogResult.Yes)
            return;

        repositorioQuestao.Excluir(QuestaoSelecionada.Id);

        CarregarQuestoes();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{QuestaoSelecionada.Enunciado}\" foi excluído com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaQuestao == null)
            tabelaQuestao = new TabelaQuestaoControl();

        var questoes = repositorioQuestao.SelecionarTodos();

        tabelaQuestao.AtualizarRegistros(questoes);

        return tabelaQuestao;
    }

    private void CarregarQuestoes()
    {
        var Questoes = repositorioQuestao.SelecionarTodos();

        tabelaQuestao.AtualizarRegistros(Questoes);
    }

    private void AtualizarRodapeQuantidadeRegistros()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioQuestao.SelecionarTodos().Count} registro(s)...");
    }

    private bool PossuiRegistroSuficiente()
    {
        return repositorioMateria.SelecionarTodos().Any();
    }

    private bool PossuiDependencias(Questao questao)
    {
        foreach (var t in repositorioTeste.SelecionarTodos())
            if (t.Questoes.Find(q => q.Id == questao.Id) != null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    $"Não é possível excluir a questão: {questao.Enunciado}, pois possui questões associadas!");
                return true;
            }

        return false;
    }
}