using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloMateria;
using gerador_de_testes2024.ModuloTeste;

namespace gerador_de_testes2024.ModuloQuestao;

public class Questao : EntidadeBase
{
    public Questao()
    {
        Alternativas = new List<Alternativa>();
        Testes = new List<Teste>();
    }

    public Questao(Materia materia, string enunciado, List<Alternativa> alternativas) : this()
    {
        Materia = materia;
        Enunciado = enunciado;
        Alternativas = alternativas;
    }

    public Questao(int id, Materia materia, string enunciado, List<Alternativa> alternativas) : this(materia, enunciado,
        alternativas)
    {
        Id = id;
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
        var validator = new QuestaoValidator();
        var validationResult = validator.Validate(this);
        return validationResult.Errors.Select(e => e.ErrorMessage).ToList();
    }

    public Alternativa RetornarRespostaCorreta()
    {
        return Alternativas.FirstOrDefault(a => a.Correta);
    }

    public int QuantidadeRespostaCorreta()
    {
        return Alternativas.Count(a => a.Correta);
    }

    public bool EnunciadoIgual(List<Questao> questoes)
    {
        return questoes.Any(q => q.Enunciado == Enunciado);
    }

    public override string ToString()
    {
        return Enunciado;
    }

    public class Alternativa
    {
        public Alternativa(string descricao, bool correta = false)
        {
            Descricao = descricao;
            Correta = correta;
        }

        public string Descricao { get; set; }
        public bool Correta { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}