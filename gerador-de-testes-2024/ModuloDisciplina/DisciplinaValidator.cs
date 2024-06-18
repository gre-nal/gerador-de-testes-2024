using FluentValidation;

namespace gerador_de_testes2024.ModuloDisciplina;

public class DisciplinaValidator : AbstractValidator<Disciplina>
{
    public DisciplinaValidator()
    {
        RuleFor(d => d.Nome)
            .NotEmpty().WithMessage("O campo \"nome\" é obrigatório");
    }
}