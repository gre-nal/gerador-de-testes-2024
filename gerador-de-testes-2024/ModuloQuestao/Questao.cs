using FluentValidation;
using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.ModuloQuestao;

public class Questao : EntidadeBase
{
    public Questao()
    {
    }

    public Questao(Materia materia, string enunciado, List<Alternativa> alternativas)
    {
        Materia = materia;
        Enunciado = enunciado;
        Alternativas = alternativas;
        Testes = new List<Teste>();
    }

    public Questao(int id, Materia materia, string enunciado, List<Alternativa> alternativas)
    {
        Id = id;
        Materia = materia;
        Enunciado = enunciado;
        Alternativas = alternativas;
        Testes = new List<Teste>();
    }

    public Materia Materia { get; set; }
    public string Enunciado { get; set; }
    public List<Alternativa> Alternativas { get; set; }
    public List<Teste> Testes { get; set; }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var q = (Questao)novoRegistro;
        Materia = q.Materia;
        Enunciado = q.Enunciado;
        Alternativas = q.Alternativas;
    }

    public override List<string> Validar()
    {
        var erros = new List<string>();

        if (string.IsNullOrEmpty(Enunciado.Trim()))
            erros.Add("O campo \"Enunciado\" é obrigatório");

        if (Alternativas.Count < 2)
            erros.Add("Deve haver ao menos duas alternativas.");

        if (Alternativas.Count > 4)
            erros.Add("Deve haver menos de cinco alternativas.");

        if (QuantidadeRespostaCorreta() == 0)
            erros.Add("Deve haver ao menos uma resposta correta entre as alternativas.");

        if (QuantidadeRespostaCorreta() > 1)
            erros.Add("Deve haver apenas uma resposta correta entre as alternativas.");

        return erros;
    }

    public Alternativa RetornarRespostaCorreta()
    {
        foreach (var a in Alternativas)
            if (a.Correta)
                return a;
        return null;
    }

    public int QuantidadeRespostaCorreta()
    {
        var quantidade = 0;
        foreach (var a in Alternativas)
            if (a.Correta)
                quantidade++;
        return quantidade;
    }

    public bool EnunciadoIgual(List<Questao> questoes)
    {
        foreach (var q in questoes)
            if (q.Enunciado == Enunciado)
                return true;
        return false;
    }

    public override string ToString()
    {
        return $"{Enunciado}";
    }

    public class Alternativa
    {
        public Alternativa(string descricao)
        {
            Descricao = descricao;
            Correta = false;
        }

        public string Descricao { get; set; }
        public bool Correta { get; set; }

        public void MarcarCorreta()
        {
            Correta = true;
        }

        public override string ToString()
        {
            return $"{Descricao}";
        }

        public void LimparRespostaCorreta()
        {
            Correta = false;
        }
    }

    public class QuestaoValidator : AbstractValidator<Questao>
    {
        public QuestaoValidator()
        {
            RuleFor(q => q.Enunciado)
                .NotEmpty().WithMessage("O campo \"Enunciado\" é obrigatório");

            RuleFor(q => q.Alternativas)
                .Must(a => a.Count >= 2).WithMessage("Deve haver ao menos duas alternativas.")
                .Must(a => a.Count <= 4).WithMessage("Deve haver menos de cinco alternativas.");

            RuleFor(q => q.Alternativas)
                .Must(a => QuantidadeRespostaCorreta(a) >= 1)
                .WithMessage("Deve haver ao menos uma resposta correta entre as alternativas.")
                .Must(a => QuantidadeRespostaCorreta(a) <= 1)
                .WithMessage("Deve haver apenas uma resposta correta entre as alternativas.");
        }

        private int QuantidadeRespostaCorreta(List<Alternativa> alternativas)
        {
            var quantidade = 0;
            foreach (var a in alternativas)
                if (a.Correta)
                    quantidade++;
            return quantidade;
        }
    }
}