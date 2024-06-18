using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace gerador_de_testes2024.ModuloTeste;

public partial class TelaGerarPdfForm : Form
{
    private readonly List<Disciplina> disciplinas;
    private readonly List<Materia> materias;
    private readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    private readonly List<Questao> questoes;
    private readonly Teste testeSelecionado;
    private string conteudoPdf = "";

    public TelaGerarPdfForm(Teste testeSelecionado, List<Disciplina> disciplinas, List<Materia> materias,
        List<Questao> questoes)
    {
        InitializeComponent();
        this.testeSelecionado = testeSelecionado;
        this.materias = materias;
        this.disciplinas = disciplinas;
        this.questoes = questoes;
        this.ConfigurarDialog();
    }

    public string Caminho { get; private set; } = "";

    private void btnGravar_Click(object sender, EventArgs e)
    {
        MontarConteudo();

        Caminho = "";

        if (cbGabarito.Checked)
            Caminho = $"{path}\\ProvaGabaritada.pdf";
        else
            Caminho = $"{path}\\Prova.pdf";

        if (!File.Exists(Caminho))
        {
            GerarPdf(Caminho);
            return;
        }

        var resposta = MessageBox.Show("O arquivo PDF já existe!\n Deseja substitui-lo?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (resposta != DialogResult.Yes)
        {
            DialogResult = DialogResult.None;
            return;
        }

        GerarPdf(Caminho);
    }

    private void MontarConteudo()
    {
        foreach (var d in disciplinas)
            if (d.Id == testeSelecionado.Disciplina.Id)
                conteudoPdf += $"Disciplina: {d}.\n";

        foreach (var m in materias)
            if (m.Id == testeSelecionado.Materia.Id)
                conteudoPdf += $"Matéria: {m}.\n";

        var numeroQuestao = 1;
        conteudoPdf += "QUESTÕES";

        foreach (var quest in testeSelecionado.Questoes)
            if (questoes.Find(q => q.Id == quest.Id) != null)
            {
                conteudoPdf += $"{numeroQuestao}) {quest}\n";
                numeroQuestao++;

                foreach (var alt in quest.Alternativas)
                    if (cbGabarito.Checked && alt.Correta)
                        conteudoPdf += $"(X) {alt}\n";
                    else
                        conteudoPdf += $"( ) {alt}\n";

                conteudoPdf += "\n";
            }
    }

    private void GerarPdf(string caminho)
    {
        using (var fs = new FileStream(caminho, FileMode.Create))
        {
            var document = new Document(PageSize.A4, 2f, 2f, 2f, 2f);
            var writer = PdfWriter.GetInstance(document, fs);

            document.Open();

            document.Add(new Paragraph(testeSelecionado.Titulo));

            var content = new Paragraph(conteudoPdf);
            document.Add(content);

            document.Close();
        }
    }
}