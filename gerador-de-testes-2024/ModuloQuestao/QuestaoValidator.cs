using FluentValidation;

namespace gerador_de_testes2024.ModuloQuestao;

public class QuestaoValidator : AbstractValidator<Questao>
{
    public QuestaoValidator()
    {
        RuleFor(q => q.Enunciado)
            .NotEmpty().WithMessage("O campo \"Enunciado\" é obrigatório");

        RuleFor(q => q.Alternativas)
            .Must(a => a.Count >= 2 && a.Count <= 4)
            .WithMessage("Deve haver entre duas e quatro alternativas.");

        RuleFor(q => q.Alternativas)
            .Must(a => a.Count(alternativa => alternativa.Correta) == 1)
            .WithMessage("Deve haver exatamente uma resposta correta entre as alternativas.");
    }
}