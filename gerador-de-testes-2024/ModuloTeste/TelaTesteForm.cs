using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloTeste;

public partial class TelaTesteForm : Form
{
    private readonly List<Materia> materias;
    private readonly List<Teste> testes;
    private readonly List<Questao> todasAsQuestoes;
    private Disciplina disciplina;
    private bool duplicar;
    private int id = -1;
    private List<Questao> questoesDisponiveis;
    private Teste teste;

    public TelaTesteForm(List<Teste> testes, List<Disciplina> disciplinas, List<Questao> questoes,
        List<Materia> materias, bool habilitarDuplicacao)
    {
        InitializeComponent();
        ConfigurarTelaDuplicacao(habilitarDuplicacao);
        this.ConfigurarDialog();
        this.testes = testes;
        todasAsQuestoes = questoes;
        this.materias = materias;
        CarregarInformacoes(disciplinas);
    }

    public Teste Teste
    {
        get => teste;
        set
        {
            id = value.Id;
            txtTitulo.Text = value.Titulo;

            if (duplicar)
                txtTitulo.Text = value.Titulo + " - Cópia";

            cmbDisciplina.SelectedItem = value.Disciplina;

            checkBoxRecuperacao.Checked = value.Recuperacao;

            if (value.Serie.Contains("1"))
                rdbPrimeiraSerie.Checked = true;
            else
                rdbSegundaSerie.Checked = true;

            cmbMateria.SelectedItem = value.Materia;

            numQuestoes.Maximum = value.RetornarQuantidadeQuestoes();
            numQuestoes.Value = value.RetornarQuantidadeQuestoes();

            if (value.Recuperacao)
            {
                cmbMateria.Enabled = false;
                cmbMateria.SelectedIndex = -1;
            }

            if (!duplicar)
                CarregarListaQuestoes(value.Questoes, todasAsQuestoes);
        }
    }

    private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
    {
        listQuestoes.Items.Clear();
        if (cmbMateria.SelectedItem != null)
        {
            numQuestoes.Value = 0;
            var materiaSelecionada = (Materia)cmbMateria.SelectedItem;
            numQuestoes.Maximum = materiaSelecionada.QuantidadeQuestoes(todasAsQuestoes);
            questoesDisponiveis = materiaSelecionada.ListaQuestoes(todasAsQuestoes);
            HabilitarSerie(false);
        }
        else if (checkBoxRecuperacao.Checked)
        {
            HabilitarSerie(true);
            numQuestoes.Value = 0;
        }
    }

    private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
    {
        listQuestoes.Items.Clear();
        SelecionarQuestoesDisciplina();
        if (!checkBoxRecuperacao.Checked)
        {
            disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            cmbMateria.Items.Clear();
            foreach (var m in materias)
                if (m.Disciplina.Id == disciplina.Id)
                    cmbMateria.Items.Add(m);
        }
    }

    private void HabilitarSerie(bool condicao)
    {
        rdbPrimeiraSerie.Enabled = condicao;
        rdbPrimeiraSerie.Checked = false;
        rdbSegundaSerie.Enabled = condicao;
        rdbSegundaSerie.Checked = false;
    }

    private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxRecuperacao.Checked)
        {
            HabilitarSerie(true);
            cmbMateria.SelectedIndex = -1;
            cmbMateria.Enabled = false;
            SelecionarQuestoesDisciplina();
        }
        else
        {
            HabilitarSerie(false);
            cmbMateria.Enabled = true;
            numQuestoes.Value = 0;
            numQuestoes.Maximum = 0;
        }
    }

    private void btnSortear_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(RetornarSerieString()) && cmbMateria.SelectedItem == null)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("É necessário selecionar uma \"Série\" para sortear questões");
            return;
        }

        var questoesSorteadas = new List<Questao>();

        SortearQuestoes(questoesSorteadas);

        listQuestoes.Items.Clear();
        foreach (var q in questoesSorteadas) listQuestoes.Items.Add(q);
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
        var titulo = txtTitulo.Text.Trim();

        var disciplina = (Disciplina)cmbDisciplina.SelectedItem;

        var questoesSelecionadas = new List<Questao>();

        foreach (Questao q in listQuestoes.Items) questoesSelecionadas.Add(q);
        var serie = RetornarSerieString();

        if (id != -1 && !duplicar)
            teste = new Teste(id, titulo, serie, disciplina, questoesSelecionadas);
        else
            teste = new Teste(titulo, serie, disciplina, questoesSelecionadas);

        if (checkBoxRecuperacao.Checked)
            teste.Recuperacao = true;

        if (!checkBoxRecuperacao.Checked && cmbMateria.SelectedItem != null)
        {
            teste.Materia = (Materia)cmbMateria.SelectedItem;
            teste.Serie = teste.Materia.Serie;
        }

        var erros = teste.Validar();

        if (erros.Count > 0)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            DialogResult = DialogResult.None;
        }

        if (teste.TituloTesteIgual(testes))
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"Já existe um \"Teste\" com o título de: \"{teste.Titulo}\"");
            DialogResult = DialogResult.None;
        }
    }

    private void CarregarInformacoes(List<Disciplina> disciplinas)
    {
        numQuestoes.Maximum = 0;
        foreach (var disciplina in disciplinas) cmbDisciplina.Items.Add(disciplina);
        cmbDisciplina.SelectedIndex = 0;
    }

    private void SortearQuestoes(List<Questao> questoesSorteadas)
    {
        var copiaQuestoes = new List<Questao>(questoesDisponiveis);

        var rand = new Random();

        while (questoesSorteadas.Count < numQuestoes.Value)
        {
            var index = rand.Next(copiaQuestoes.Count);
            questoesSorteadas.Add(copiaQuestoes[index]);
            copiaQuestoes.RemoveAt(index);
        }
    }

    private void CarregarListaQuestoes(List<Questao> questoesDoTeste, List<Questao> questoes)
    {
        listQuestoes.Items.Clear();
        foreach (var quest in questoesDoTeste) listQuestoes.Items.Add(questoes.Find(q => q.Id == quest.Id));
    }

    private void ConfigurarTelaDuplicacao(bool habilitarDuplicacao)
    {
        if (habilitarDuplicacao)
        {
            duplicar = habilitarDuplicacao;
            Text = "Duplicação de Teste";
        }
    }

    private string RetornarSerieString()
    {
        if (rdbSegundaSerie.Checked)
            return "2ª Série";

        if (rdbPrimeiraSerie.Checked)
            return "1ª Série";

        return "";
    }

    private void SelecionarQuestoesDisciplina()
    {
        numQuestoes.Value = 0;
        var disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;
        if ((rdbPrimeiraSerie.Checked || rdbSegundaSerie.Checked) && checkBoxRecuperacao.Checked)
        {
            numQuestoes.Maximum = disciplinaSelecionada.QuantidadeQuestoes(todasAsQuestoes, RetornarSerieString());
            questoesDisponiveis = disciplinaSelecionada.ListaQuestoes(todasAsQuestoes, RetornarSerieString());
        }
    }

    private void rdbPrimeiraSerie_CheckedChanged(object sender, EventArgs e)
    {
        SelecionarQuestoesDisciplina();
    }

    private void rdbSegundaSerie_CheckedChanged(object sender, EventArgs e)
    {
        SelecionarQuestoesDisciplina();
    }
}