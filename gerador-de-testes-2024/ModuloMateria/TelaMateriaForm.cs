using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;

namespace gerador_de_testes2024.ModuloMateria;

public partial class TelaMateriaForm : Form
{
    private readonly List<Materia> materias;
    private int id = -1;
    private Materia materia;

    public TelaMateriaForm(List<Disciplina> disciplinas, List<Materia> materias)
    {
        InitializeComponent();
        this.ConfigurarDialog();
        CarregarComboBox(disciplinas);
        this.materias = materias;
    }

    public Materia Materia
    {
        set
        {
            id = value.Id;
            txtNomeMateria.Text = value.Nome;
            radioButtonSerie1.Checked = value.PrimeiraSerieMarcada();
            if (!radioButtonSerie1.Checked)
                radioButtonSerie2.Checked = true;
            comboBoxMateriaDisciplina.SelectedItem = value.Disciplina;
        }
        get => materia;
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var nome = txtNomeMateria.Text.Trim();
        var serie = "";
        if (radioButtonSerie1.Checked)
            serie = "1ª Série";
        else if (radioButtonSerie2.Checked)
            serie = "2ª Série";

        var disciplina = (Disciplina)comboBoxMateriaDisciplina.SelectedItem;

        if (id != -1)
            materia = new Materia(id, nome, serie, disciplina);
        else
            materia = new Materia(nome, serie, disciplina);

        var erros = materia.Validar();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

            DialogResult = DialogResult.None;
        }

        if (materia.ExisteMateria(materias))
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Já existe uma \"Matéria\" com o nome de: \"{materia.Nome}\"!");

            DialogResult = DialogResult.None;
        }
    }

    private void CarregarComboBox(List<Disciplina> disciplinas)
    {
        foreach (var d in disciplinas)
            comboBoxMateriaDisciplina.Items.Add(d);

        comboBoxMateriaDisciplina.SelectedIndex = 0;
    }
}