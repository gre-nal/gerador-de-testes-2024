using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;

namespace gerador_de_testes2024.ModuloQuestao;

public partial class TelaQuestaoForm : Form
{
    private readonly List<Questao> questoes;
    private Questao.Alternativa alternativa;
    private int id = -1;
    private Questao questao;

    public TelaQuestaoForm(List<Questao> questoes, List<Materia> materias)
    {
        InitializeComponent();
        this.questoes = questoes;
        this.ConfigurarDialog();
        CarregarComboBox(materias);
    }

    public Questao Questao
    {
        get => questao;
        set
        {
            id = value.Id;
            cmbMateria.SelectedItem = value.Materia;
            txtEnunciado.Text = value.Enunciado;
            CarregarLista(value);
        }
    }

    private void CarregarLista(Questao questao)
    {
        var i = 0;
        foreach (var a in questao.Alternativas)
        {
            listAlternativas.Items.Add(a);
            if (a.Correta)
                listAlternativas.SetItemChecked(i, true);
            i++;
        }
    }

    private void CarregarComboBox(List<Materia> materias)
    {
        foreach (var m in materias) cmbMateria.Items.Add(m);
        cmbMateria.SelectedIndex = 0;
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        if (listAlternativas.Items.Count == 10)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar mais de 10 alternativas.");
            return;
        }

        var descricao = txtResposta.Text.Trim();

        if (string.IsNullOrEmpty(descricao))
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar uma alternativa vazia.");
            return;
        }

        alternativa = new Questao.Alternativa(descricao);
        listAlternativas.Items.Add(alternativa);
    }

    private void btnRemover_Click(object sender, EventArgs e)
    {
        if (listAlternativas.SelectedIndex != -1)
            listAlternativas.Items.RemoveAt(listAlternativas.SelectedIndex);

        else
            MessageBox.Show(
                "Não é possível realizar esta ação sem uma alternativa selecionada.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var materia = (Materia)cmbMateria.SelectedItem;
        var enunciado = txtEnunciado.Text.Trim();

        var alternativas = new List<Questao.Alternativa>();

        foreach (Questao.Alternativa a in listAlternativas.Items)
        {
            if (listAlternativas.CheckedItems.Contains(a)) a.Correta = true;
            alternativas.Add(a);
        }

        if (id != -1)
            questao = new Questao(id, materia, enunciado, alternativas);
        else
            questao = new Questao(materia, enunciado, alternativas);

        var erros = questao.Validar();
        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            DialogResult = DialogResult.None;
        }

        if (questao.EnunciadoIgual(questoes))
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível cadastrar uma questão com o mesmo enunciado");
            DialogResult = DialogResult.None;
        }
    }
}