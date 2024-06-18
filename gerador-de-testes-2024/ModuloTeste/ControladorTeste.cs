using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloTeste;

internal class ControladorTeste : ControladorBase, IControladorCopiarTeste, IControladorVisualizavel, IControladorPDF
{
    private readonly IRepositorioDisciplina repositorioDisciplina;
    private readonly IRepositorioMateria repositorioMateria;
    private readonly IRepositorioQuestao repositorioQuestao;
    private readonly IRepositorioTeste repositorioTeste;
    private TabelaTesteControl tabelaTeste;

    public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioDisciplina repositorioDisciplina,
        IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
    {
        this.repositorioTeste = repositorioTeste;
        this.repositorioDisciplina = repositorioDisciplina;
        this.repositorioQuestao = repositorioQuestao;
        this.repositorioMateria = repositorioMateria;
        AtualizarRodapeQuantidadeRegistros();
    }

    public override string TipoCadastro => "Testes";

    public override string ToolTipAdicionar => "Cadastrar um novo teste";

    public override string ToolTipEditar => "Editar um teste existente";

    public override string ToolTipExcluir => "Excluir um teste existente";

    public string ToolTipDuplicar => "Duplicar o teste selecionado";

    public string ToolTipCopiarTeste { get; }

    public void Duplicar()
    {
        var testeSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());
        if (testeSelecionado == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        var telaTeste = new TelaTesteForm(
            repositorioTeste.SelecionarTodos(),
            repositorioDisciplina.SelecionarTodos(),
            repositorioQuestao.SelecionarTodos(),
            repositorioMateria.SelecionarTodos(),
            true);

        telaTeste.Teste = testeSelecionado;

        var resultado = telaTeste.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoTeste = telaTeste.Teste;

        repositorioTeste.Cadastrar(novoTeste);

        CarregarTestes();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");
    }

    public string ToolTipPDF => "Gerar arquivo PDF do teste selecionado";

    public void GerarPDF()
    {
        var testeSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());
        if (testeSelecionado == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        var telaGerarPdf = new TelaGerarPdfForm(
            testeSelecionado,
            repositorioDisciplina.SelecionarTodos(),
            repositorioMateria.SelecionarTodos(),
            repositorioQuestao.SelecionarTodos());

        var resultado = telaGerarPdf.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var caminho = telaGerarPdf.Caminho;

        TelaPrincipalForm.Instancia.AtualizarRodape($"O arquivo foi gerado com sucesso em: {caminho}");
    }

    public string ToolTipVisualizar => "Visualizar os detalhes do teste selecionado";

    public void Visualizar()
    {
        var testeSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());
        if (testeSelecionado == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        var telaVisualisar = new TelaVisualizarTesteForm(
            testeSelecionado,
            repositorioDisciplina.SelecionarTodos(),
            repositorioMateria.SelecionarTodos(),
            repositorioQuestao.SelecionarTodos());

        telaVisualisar.ShowDialog();
    }

    public override void Adicionar()
    {
        if (!ValidarExisteRegistrosSuficientes())
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"Não é possível realizar o cadastro de \"Teste\" " +
                                                        $"sem possuir uma \"Questão\" cadastradas!");
            return;
        }

        var telaTeste = new TelaTesteForm(
            repositorioTeste.SelecionarTodos(),
            repositorioDisciplina.SelecionarTodos(),
            repositorioQuestao.SelecionarTodos(),
            repositorioMateria.SelecionarTodos(),
            false);

        var resultado = telaTeste.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var novoTeste = telaTeste.Teste;

        repositorioTeste.Cadastrar(novoTeste);


        CarregarTestes();

        TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");
    }

    public override void Editar()
    {
        var testeSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());

        var telaTeste = new TelaTesteForm(
            repositorioTeste.SelecionarTodos(),
            repositorioDisciplina.SelecionarTodos(),
            repositorioQuestao.SelecionarTodos(),
            repositorioMateria.SelecionarTodos(),
            false);

        if (testeSelecionado == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        telaTeste.Teste = testeSelecionado;

        var resultado = telaTeste.ShowDialog();

        if (resultado != DialogResult.OK)
            return;

        var TesteEditado = telaTeste.Teste;


        repositorioTeste.Editar(testeSelecionado.Id, TesteEditado);
        CarregarTestes();

        TelaPrincipalForm
            .Instancia
            .AtualizarRodape($"O registro \"{TesteEditado.Titulo}\" foi editado com sucesso!");
    }

    public override void Excluir()
    {
        var testeSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());
        if (testeSelecionado == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        var resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{testeSelecionado.Titulo}\"?"
            , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (resposta != DialogResult.Yes)
            return;

        repositorioTeste.Excluir(testeSelecionado.Id);

        CarregarTestes();

        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"O registro \"{testeSelecionado.Titulo}\" foi excluído com sucesso!");
    }

    public override UserControl ObterListagem()
    {
        if (tabelaTeste == null)
            tabelaTeste = new TabelaTesteControl();

        var questoes = repositorioTeste.SelecionarTodos();

        tabelaTeste.AtualizarRegistros(questoes);

        return tabelaTeste;
    }

    private void CarregarTestes()
    {
        var Testes = repositorioTeste.SelecionarTodos();

        tabelaTeste.AtualizarRegistros(Testes);
    }

    private void AtualizarRodapeQuantidadeRegistros()
    {
        TelaPrincipalForm.Instancia.AtualizarRodape(
            $"Visualizando {repositorioTeste.SelecionarTodos().Count} registro(s)...");
    }

    private bool ValidarExisteRegistrosSuficientes()
    {
        if (repositorioQuestao.SelecionarTodos().Any())
            return true;
        return false;
    }
}