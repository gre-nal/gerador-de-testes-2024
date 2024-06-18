using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.ModuloDisciplina;

public class Disciplina : EntidadeBase
{
    public Disciplina()
    {
        Materias = new List<Materia>();
        Testes = new List<Teste>();
    }

    public Disciplina(string nome) : this()
    {
        Nome = nome;
    }

    public Disciplina(int id, string nome) : this(nome)
    {
        Id = id;
    }

    public string Nome { get; set; }
    public List<Materia> Materias { get; set; }
    public List<Teste> Testes { get; set; }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var novaDisciplina = (Disciplina)novoRegistro;
        Nome = novaDisciplina.Nome;
        Materias = novaDisciplina.Materias;
        Testes = novaDisciplina.Testes;
    }

    public override List<string> Validar()
    {
        var validator = new DisciplinaValidator();
        var validationResult = validator.Validate(this);
        return validationResult.Errors.Select(e => e.ErrorMessage).ToList();
    }

    public bool ExisteDisciplina(List<Disciplina> disciplinas)
    {
        return disciplinas.Any(d => d.Nome == Nome);
    }

    public override string ToString()
    {
        return Nome;
    }

    public decimal QuantidadeQuestoes(List<Questao> questoes, string serie)
    {
        return questoes.Count(q => q.Materia.Disciplina.Id == Id && q.Materia.Serie == serie);
    }

    public List<Questao> ListaQuestoes(List<Questao> questoes, string serie)
    {
        return questoes.Where(q => q.Materia.Disciplina.Id == Id && q.Materia.Serie == serie).ToList();
    }
}