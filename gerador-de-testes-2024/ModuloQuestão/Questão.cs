using gerador_de_testes_2024.Compartilhado;

namespace gerador_de_testes_2024.ModuloQuestao
{
    public class Alternativa
    {
        public string Texto { get; set; }
        public bool Correta { get; set; }
        public int Id { get; set; }

        public Alternativa(string texto, bool correta, int id)
        {
            Texto = texto;
            Correta = correta;
            id = id;
        }
    }

    public class Questao
    {
        public int Id { get; set; }
        public string Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; } = new List<Alternativa>();

        public Questao(int id, string materia, string enunciado)
        {
            Id = id;
            Materia = materia;
            Enunciado = enunciado;
        }

        public void AdicionarAlternativa(Alternativa alternativa)
        {
            if (Alternativas.Count < 4)
            {
                Alternativas.Add(alternativa);
            }
            else
            {
                throw new Exception("Não é possível adicionar mais de 4 alternativas.");
            }
        }

        public void RemoverAlternativa(Alternativa alternativa)
        {
            Alternativas.Remove(alternativa);
        }
    }
}