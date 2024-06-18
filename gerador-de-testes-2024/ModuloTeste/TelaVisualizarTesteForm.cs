using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloTeste;

public partial class TelaVisualizarTesteForm : Form
{
    public TelaVisualizarTesteForm(Teste testeSelecionado, List<Disciplina> disciplinas, List<Materia> materias,
        List<Questao> questoes)
    {
        InitializeComponent();
        this.ConfigurarDialog();
        CarregarInformacoes(testeSelecionado, disciplinas, materias, questoes);
    }

    private void CarregarInformacoes(Teste testeSelecionado, List<Disciplina> disciplinas, List<Materia> materias,
        List<Questao> questoes)
    {
        txtTitulo.Text = testeSelecionado.Titulo;

        foreach (var d in disciplinas)
            if (d.Id == testeSelecionado.Disciplina.Id)
                txtDisciplina.Text = d.Nome;
        foreach (var m in materias)
            if (m.Id == testeSelecionado.Materia.Id)
                txtMateria.Text = m.Nome;
        foreach (var quest in testeSelecionado.Questoes) listQuestoes.Items.Add(questoes.Find(q => q.Id == quest.Id));
    }
}