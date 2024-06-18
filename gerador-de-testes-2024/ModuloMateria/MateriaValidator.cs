using FluentValidation;

namespace gerador_de_testes2024.ModuloMateria;

public class MateriaValidator : AbstractValidator<Materia>
{
    public MateriaValidator()
    {
        RuleFor(m => m.Nome)
            .NotEmpty().WithMessage("O campo \"nome\" é obrigatório");

        RuleFor(m => m.Serie)
            .NotEmpty().WithMessage("Ao menos uma das \"séries\" deve ser selecionada");
    }
}