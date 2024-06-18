using gerador_de_testes2024.Compartilhado;

namespace gerador_de_testes2024.ModuloDisciplina;

public partial class TelaDisciplinaForm : Form
{
    private readonly List<Disciplina> disciplinas;
    private Disciplina disciplina;
    private int id = -1;

    public TelaDisciplinaForm(List<Disciplina> disciplinas)
    {
        InitializeComponent();
        this.disciplinas = disciplinas;
        this.ConfigurarDialog();
    }

    public Disciplina Disciplina
    {
        set
        {
            id = value.Id;
            txtNomeDisciplina.Text = value.Nome;
        }
        get => disciplina;
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var nome = txtNomeDisciplina.Text.Trim();

        if (id != -1)
            disciplina = new Disciplina(id, nome);
        else
            disciplina = new Disciplina(nome);


        var erros = disciplina.Validar();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }

        if (disciplina.ExisteDisciplina(disciplinas))
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Já existe uma \"Disciplina\" com o nome de: \"{disciplina.Nome}\"!");

            DialogResult = DialogResult.None;
        }
    }
}