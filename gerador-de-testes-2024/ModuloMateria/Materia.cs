using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloMateria;

public class Materia : EntidadeBase
{
    public Materia()
    {
    }

    public Materia(string nome, string serie, Disciplina disciplina)
    {
        Nome = nome;
        Serie = serie;
        Disciplina = disciplina;
        Questoes = new List<Questao>();
    }

    public Materia(int id, string nome, string serie, Disciplina disciplina)
    {
        Id = id;
        Nome = nome;
        Serie = serie;
        Disciplina = disciplina;
        Questoes = new List<Questao>();
    }

    public string Nome { get; set; }
    public string Serie { get; set; }
    public Disciplina Disciplina { get; set; }
    public List<Questao> Questoes { get; set; }

    public override List<string> Validar()
    {
        var validator = new MateriaValidator();
        var validationResult = validator.Validate(this);
        return validationResult.Errors.Select(error => error.ErrorMessage).ToList();
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var m = (Materia)novoRegistro;

        Nome = m.Nome;
        Serie = m.Serie;
        Disciplina = m.Disciplina;
    }

    public override string ToString()
    {
        return $"{Nome}, {Serie}";
    }

    public bool PrimeiraSerieMarcada()
    {
        if (Serie.Contains("1"))
            return true;

        return false;
    }

    public int QuantidadeQuestoes(List<Questao> questoes)
    {
        var count = 0;

        foreach (var q in questoes)
            if (q.Materia.Id == Id)
                count++;


        return count;
    }

    public List<Questao> ListaQuestoes(List<Questao> questoes)
    {
        var questoesDisponiveis = new List<Questao>();

        foreach (var q in questoes)
            if (q.Materia.Id == Id)
                questoesDisponiveis.Add(q);

        return questoesDisponiveis;
    }

    public bool ExisteMateria(List<Materia> materias)
    {
        foreach (var m in materias)
            if (m.Nome == Nome)
                return true;
        return false;
    }
}