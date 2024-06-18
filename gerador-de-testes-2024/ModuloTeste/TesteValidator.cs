using FluentValidation;

namespace gerador_de_testes2024.ModuloTeste;

public class TesteValidator : AbstractValidator<Teste>
{
    public TesteValidator()
    {
        RuleFor(teste => teste.Titulo).NotEmpty().WithMessage("O campo \"Título\" é obrigatório");
        RuleFor(teste => teste.Serie).NotEmpty().WithMessage("É necessário selecionar uma \"Série\"");
        RuleFor(teste => teste.Materia).NotNull().When(teste => !teste.Recuperacao)
            .WithMessage("É necessário selecionar uma \"Matéria\", exceto para testes de recuperação");
    }
}