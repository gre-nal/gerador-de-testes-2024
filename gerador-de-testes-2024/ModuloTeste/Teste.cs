using FluentValidation;
using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloTeste;

public class TesteValidator : AbstractValidator<Teste>
{
    public TesteValidator()
    {
        RuleFor(teste => teste.Titulo).NotEmpty().WithMessage("O campo \"Enunciado\" é obrigatório");
        RuleFor(teste => teste.Serie).NotEmpty().WithMessage("É necessário selecionar uma \"Série\"");
        RuleFor(teste => teste.Materia).NotNull().When(teste => !teste.Recuperacao)
            .WithMessage("É necessário selecionar uma \"Matéria\"");
    }
}

public class Teste : EntidadeBase
{
    public Teste()
    {
    }

    public Teste(string titulo, string serie, Disciplina disciplina, List<Questao> questoes)
    {
        Titulo = titulo;
        Serie = serie;
        Disciplina = disciplina;
        Questoes = questoes;
    }

    public Teste(int id, string titulo, string serie, Disciplina disciplina, List<Questao> questoes)
    {
        Id = id;
        Titulo = titulo;
        Serie = serie;
        Disciplina = disciplina;
        Questoes = questoes;
    }

    public string Titulo { get; set; }
    public Disciplina Disciplina { get; set; }
    public Materia Materia { get; set; }
    public string Serie { get; set; }
    public List<Questao> Questoes { get; set; }
    public bool Recuperacao { get; set; }

    public int RetornarQuantidadeQuestoes()
    {
        return Questoes.Count;
    }

    public bool TituloTesteIgual(List<Teste> testes)
    {
        foreach (var t in testes)
            if (t.Titulo == Titulo)
                return true;
        return false;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var teste = (Teste)novoRegistro;
        Titulo = teste.Titulo;
        Disciplina = teste.Disciplina;
        Materia = teste.Materia;
        Serie = teste.Serie;
        Questoes = teste.Questoes;
        Recuperacao = teste.Recuperacao;
    }

    public override List<string> Validar()
    {
        var validator = new TesteValidator();
        var validationResult = validator.Validate(this);
        return validationResult.Errors.Select(error => error.ErrorMessage).ToList();
    }
}