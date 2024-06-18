using gerador_de_testes_2024.ModuloQuestao;

namespace gerador_de_testes_2024.ModuloTeste
{
    public class Teste
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Disciplina { get; set; }
        public string Materia { get; set; } // Pode ser null se for uma prova de recuperação
        public string Serie { get; set; }
        public int QuantidadeQuestoes { get; set; }
        public List<Questao> Questoes { get; set; } = new List<Questao>();

        public Teste(int id, string titulo, string disciplina, string materia, string serie, int quantidadeQuestoes)
        {
            Id = id;
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            Serie = serie;
            QuantidadeQuestoes = quantidadeQuestoes;
        }
    }
}