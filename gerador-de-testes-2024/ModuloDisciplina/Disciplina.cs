using FluentValidation;
using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.ModuloDisciplina;

public class DisciplinaValidator : AbstractValidator<Disciplina>
{
    public DisciplinaValidator()
    {
        RuleFor(d => d.Nome)
            .NotEmpty().WithMessage("O campo \"nome\" é obrigatório");
    }
}

public class Disciplina : EntidadeBase
{
    public Disciplina()
    {
    }

    public Disciplina(string nome)
    {
        Nome = nome;
        Materias = new List<Materia>();
        Testes = new List<Teste>();
    }

    public Disciplina(int id, string nome)
    {
        Id = id;
        Nome = nome;
        Materias = new List<Materia>();
        Testes = new List<Teste>();
    }

    public string Nome { get; set; }
    public List<Materia> Materias { get; set; }
    public List<Teste> Testes { get; set; }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var d = (Disciplina)novoRegistro;

        Nome = d.Nome;
        Materias = d.Materias;
        Testes = d.Testes;
    }

    public override List<string> Validar()
    {
        var validator = new DisciplinaValidator();
        var result = validator.Validate(this);
        return result.Errors.Select(e => e.ErrorMessage).ToList();
    }

    public bool ExisteDisciplina(List<Disciplina> disciplinas)
    {
        foreach (var d in disciplinas)
            if (d.Nome == Nome)
                return true;
        return false;
    }

    public override string ToString()
    {
        return $"{Nome}";
    }

    internal decimal QuantidadeQuestoes(List<Questao> questoes, string serie)
    {
        var contador = 0;

        foreach (var q in questoes)
            if (q.Materia.Disciplina.Id == Id && q.Materia.Serie == serie)
                contador++;

        return contador;
    }

    internal List<Questao> ListaQuestoes(List<Questao> questoes, string serie)
    {
        var lista = new List<Questao>();

        foreach (var q in questoes)
            if (q.Materia.Disciplina.Id == Id && q.Materia.Serie == serie)
                lista.Add(q);
        return lista;
    }
}