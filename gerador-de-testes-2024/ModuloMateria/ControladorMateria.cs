using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloMateria;

internal class ControladorMateria : ControladorBase
{
    private readonly IRepositorioDisciplina repositorioDisciplina;
    private readonly IRepositorioMateria repositorioMateria;
    private readonly IRepositorioQuestao repositorioQuestao;
    private TabelaMateriaControl tabelaMateria;

    public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina,
        IRepositorioQuestao repositorioQuestao)
    {
        this.repositorioMateria = repositorioMateria;
        this.repositorioDisciplina = repositorioDisciplina;
        this.repositorioQuestao = repositorioQuestao;
        AtualizarRodapeQuantidadeRegistros();
    }

    public override string TipoCadastro => "Matéria";

    public override string ToolTipAdicionar => "Cadastrar uma nova matéria";

    public override string ToolTipEditar => "Editar uma matéria existente";

    public override string ToolTipExcluir => "Excluir uma matéria existente";

    public override void Adicionar()
    {
        if (!ValidarDisciplinasExistentes())
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(
                "Não é possível adicionar uma \"Matéria\" sem ter uma \"Disciplina\"!");
            return;
        }

        var telaMateria =
            new TelaMateriaForm(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos());

        var resultado = telaMateria.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novaMateria = telaMateria.Materia;

        repositorioMateria.Cadastrar(novaMateria);

        CarregarMaterias();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
    }


    public override void Editar()
    {
        if (!ValidarDisciplinasExistentes())
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(
                "Não é possível editar uma \"Matéria\" sem ter uma disciplina!");
            return;
        }

        var telaMateria =
            new TelaMateriaForm(repositorioDisciplina.SelecionarTodos(), repositorioMateria.SelecionarTodos());

        var idSelecionado = tabelaMateria.ObterRegistroSelecionado();

        var materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

        if (materiaSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        telaMateria.Materia = materiaSelecionada;

        var resultado = telaMateria.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var materiaEditada = telaMateria.Materia;

        repositorioMateria.Editar(materiaSelecionada.Id, materiaEditada);

        CarregarMaterias();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{materiaSelecionada.Nome}\" foi editado com sucesso!");
    }

    public override void Excluir()
    {
        var idSelecionado = tabelaMateria.ObterRegistroSelecionado();

        var materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

        if (materiaSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (PossuiDependencias(materiaSelecionada))
            return;

        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir o registro \"{materiaSelecionada.Nome}\" ",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resposta != DialogResult.Yes)
            return;

        repositorioMateria.Excluir(materiaSelecionada.Id);

        CarregarMaterias();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{materiaSelecionada.Nome}\" foi excluido com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaMateria == null)
            tabelaMateria = new TabelaMateriaControl();

        var materias = repositorioMateria.SelecionarTodos();

        tabelaMateria.AtualizarRegistros(materias);

        return tabelaMateria;
    }

    private void CarregarMaterias()
    {
        var materias = repositorioMateria.SelecionarTodos();

        tabelaMateria.AtualizarRegistros(materias);
    }

    private void AtualizarRodapeQuantidadeRegistros()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioMateria.SelecionarTodos().Count} registro(s)...");
    }

    private bool ValidarDisciplinasExistentes()
    {
        return repositorioDisciplina.SelecionarTodos().Any();
    }

    private bool PossuiDependencias(Materia materia)
    {
        foreach (var q in repositorioQuestao.SelecionarTodos())
            if (q.Materia.Id == materia.Id)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    $"Não é possível excluir a matéria: {materia.Nome}, pois possui questões associadas!");
                return true;
            }

        return false;
    }
}