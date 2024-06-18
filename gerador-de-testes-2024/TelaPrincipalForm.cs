using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024;

public partial class TelaPrincipalForm : Form
{
    private readonly ContextoDados contexto;
    private readonly IRepositorioDisciplina repositorioDisciplina;
    private readonly IRepositorioMateria repositorioMateria;
    private readonly IRepositorioQuestao repositorioQuestao;
    private readonly IRepositorioTeste repositorioTeste;
    private ControladorBase controlador;

    public TelaPrincipalForm()
    {
        InitializeComponent();
        contexto = new ContextoDados(true);

        lblTipoCadastro.Text = string.Empty;
        Instancia = this;

        repositorioDisciplina = new RepositorioDisciplina(contexto);
        repositorioMateria = new RepositorioMateria(contexto);
        repositorioQuestao = new RepositorioQuestao(contexto);
        repositorioTeste = new RepositorioTeste(contexto);
    }

    public static TelaPrincipalForm Instancia { get; private set; }

    public void AtualizarRodape(string texto)
    {
        statusLabelPrincipal.Text = texto;
    }

    private void DisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorDisciplina(repositorioDisciplina, repositorioMateria, repositorioTeste);

        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
        ConfigurarTelaPrincipal(controlador);
    }

    private void materiaToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina, repositorioQuestao);

        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
        ConfigurarTelaPrincipal(controlador);
    }

    private void questoesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorQuestao(repositorioQuestao, repositorioMateria, repositorioTeste);

        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
        ConfigurarTelaPrincipal(controlador);
    }

    private void testesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorTeste(repositorioTeste, repositorioDisciplina, repositorioQuestao,
            repositorioMateria);

        lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
        ConfigurarTelaPrincipal(controlador);
    }

    private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
    {
        lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

        ConfigurarToolBox(controladorSelecionado);
        ConfigurarListagem(controladorSelecionado);
    }

    private void ConfigurarToolBox(ControladorBase controladorSelecionado)
    {
        btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
        btnEditar.Enabled = controladorSelecionado is ControladorBase;
        btnExcluir.Enabled = controladorSelecionado is ControladorBase;

        btnCopiar.Enabled = controladorSelecionado is IControladorCopiarTeste;
        btnVisualizar.Enabled = controladorSelecionado is IControladorVisualizavel;
        btnPDF.Enabled = controladorSelecionado is IControladorPDF;

        ConfigurarToolTips(controladorSelecionado);
    }

    private void ConfigurarToolTips(ControladorBase controladorSelecionado)
    {
        btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
        btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
        btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

        if (controladorSelecionado is IControladorVisualizavel controladorVisualizavel)
            btnVisualizar.ToolTipText = controladorVisualizavel.ToolTipVisualizar;

        if (controladorSelecionado is IControladorCopiarTeste controladorDuplicavel)
            btnCopiar.ToolTipText = controladorDuplicavel.ToolTipCopiarTeste;

        if (controladorSelecionado is IControladorPDF controladorPDF)
            btnPDF.ToolTipText = controladorPDF.ToolTipPDF;
    }

    private void ConfigurarListagem(ControladorBase controladorSelecionado)
    {
        var listagem = controladorSelecionado.ObterListagem();
        listagem.Dock = DockStyle.Fill;

        pnlRegistros.Controls.Clear();
        pnlRegistros.Controls.Add(listagem);
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        controlador.Adicionar();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        controlador.Editar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        controlador.Excluir();
    }

    private void btnDuplicar_Click(object sender, EventArgs e)
    {
        if (controlador is IControladorCopiarTeste controladorDuplicavel)
            controladorDuplicavel.Duplicar();
    }

    private void btnVisualizar_Click(object sender, EventArgs e)
    {
        if (controlador is IControladorVisualizavel controladorVisualizavel)
            controladorVisualizavel.Visualizar();
    }

    private void btnPDF_Click(object sender, EventArgs e)
    {
        if (controlador is IControladorPDF controladorPDF)
            controladorPDF.GerarPDF();
    }

    private void TelaPrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void telaInicialToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        var telaInicial = new TelaPrincipalForm();
        telaInicial.Show();
        Hide();
    }
}