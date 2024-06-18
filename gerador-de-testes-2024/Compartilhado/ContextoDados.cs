using System.Text.Json;
using System.Text.Json.Serialization;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.Compartilhado;

public class ContextoDados
{
    private string caminho = Directory.GetCurrentDirectory().Split("bin")[0] + "\\Dados\\Dados.json";

    public ContextoDados()
    {
        Disciplinas = new List<Disciplina>();
        Materias = new List<Materia>();
        Questoes = new List<Questao>();
        Testes = new List<Teste>();
    }

    public ContextoDados(bool carregarDados) : this()
    {
        if (carregarDados)
            CarregarDados();
    }

    public List<Disciplina> Disciplinas { get; set; }
    public List<Materia> Materias { get; set; }
    public List<Questao> Questoes { get; set; }
    public List<Teste> Testes { get; set; }

    public void Gravar()
    {
        var arquivo = new FileInfo(caminho);

        arquivo.Directory.Create();

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.Preserve
        };

        var registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

        File.WriteAllBytes(caminho, registrosEmBytes);
    }

    protected void CarregarDados()
    {
        var arquivo = new FileInfo(caminho);

        if (!arquivo.Exists)
            return;

        var registrosEmBytes = File.ReadAllBytes(caminho);

        var options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve
        };

        var ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

        if (ctx == null)
            return;

        Disciplinas = ctx.Disciplinas;
        Materias = ctx.Materias;
        Questoes = ctx.Questoes;
        Testes = ctx.Testes;
    }
}