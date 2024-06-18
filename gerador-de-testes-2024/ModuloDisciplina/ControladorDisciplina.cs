using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.ModuloDisciplina;

public class ControladorDisciplina : ControladorBase
{
    private readonly IRepositorioDisciplina repositorioDisciplina;
    private readonly IRepositorioMateria repositorioMateria;
    private readonly IRepositorioTeste repositorioTeste;
    private TabelaDisciplinaControl tabelaDisciplina;

    public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina,
        IRepositorioMateria repositorioMateria, IRepositorioTeste repositorioTeste)
    {
        this.repositorioDisciplina = repositorioDisciplina;
        this.repositorioMateria = repositorioMateria;
        this.repositorioTeste = repositorioTeste;
        AtualizarRodapeQuantidadeRegistros();
    }

    public override string TipoCadastro => "Disciplina";

    public override string ToolTipAdicionar => "Cadastrar uma nova disciplina";

    public override string ToolTipEditar => "Editar uma disciplina existente";
    public override string ToolTipExcluir => "Excluir uma disciplina existente";

    public override void Adicionar()
    {
        var telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

        var resultado = telaDisciplina.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novaDisciplina = telaDisciplina.Disciplina;

        repositorioDisciplina.Cadastrar(novaDisciplina);

        CarregarDisciplinas();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaDisciplina.Nome}\" foi criado com sucesso!");
    }

    public override void Editar()
    {
        var telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

        var idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

        var disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

        if (disciplinaSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        telaDisciplina.Disciplina = disciplinaSelecionada;

        var resultado = telaDisciplina.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var disciplinaEditada = telaDisciplina.Disciplina;

        repositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);

        CarregarDisciplinas();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{disciplinaEditada.Nome}\" foi editado com sucesso!");
    }

    public override void Excluir()
    {
        var idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

        var disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

        if (disciplinaSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (PossuiDependencias(disciplinaSelecionada))
            return;

        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Nome}\" ",
            "Confirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (resposta != DialogResult.Yes)
            return;

        repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

        CarregarDisciplinas();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{disciplinaSelecionada.Nome}\" foi excluído com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaDisciplina == null)
            tabelaDisciplina = new TabelaDisciplinaControl();

        var disciplinas = repositorioDisciplina.SelecionarTodos();

        tabelaDisciplina.AtualizarRegistros(disciplinas);

        return tabelaDisciplina;
    }

    private void CarregarDisciplinas()
    {
        var disciplinas = repositorioDisciplina.SelecionarTodos();

        tabelaDisciplina.AtualizarRegistros(disciplinas);
    }

    private void AtualizarRodapeQuantidadeRegistros()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioDisciplina.SelecionarTodos().Count} registro(s)...");
    }

    private bool PossuiDependencias(Disciplina disciplina)
    {
        foreach (var m in repositorioMateria.SelecionarTodos())
            if (m.Disciplina.Id == disciplina.Id)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    $"Não é possível excluir a disciplina: {disciplina.Nome}, pois possui matérias ou testes associadas!");
                return true;
            }

        foreach (var t in repositorioTeste.SelecionarTodos())
            if (t.Disciplina.Id == disciplina.Id)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(
                    $"Não é possível excluir a disciplina: {disciplina.Nome}, pois possui testes associados!");
                return true;
            }

        return false;
    }
}