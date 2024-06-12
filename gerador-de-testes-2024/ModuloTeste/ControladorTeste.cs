using gerador_de_testes_2024.ModuloQuestao;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace gerador_de_testes_2024.ModuloTeste
{
    internal class ControladorTeste
    {
        private List<Teste> testes = new List<Teste>();
        private int ultimoId = 0;

        public bool AdicionarTeste(string titulo, string disciplina, string materia, string serie,
            int quantidadeQuestoes, List<Questao> questoesSelecionadas)
        {
            if (string.IsNullOrWhiteSpace(titulo) || testes.Any(t => t.Titulo == titulo) ||
                quantidadeQuestoes > questoesSelecionadas.Count)
            {
                return false;
            }

            var teste = new Teste(++ultimoId, titulo, disciplina, materia, serie, quantidadeQuestoes);
            teste.Questoes.AddRange(questoesSelecionadas.Take(quantidadeQuestoes));
            testes.Add(teste);
            return true;
        }

        public Teste DuplicarTeste(int id)
        {
            var testeOriginal = testes.FirstOrDefault(t => t.Id == id);
            if (testeOriginal == null)
            {
                return null;
            }

            var novoTeste = new Teste(++ultimoId, $"{testeOriginal.Titulo} - Cópia", testeOriginal.Disciplina,
                testeOriginal.Materia, testeOriginal.Serie, testeOriginal.QuantidadeQuestoes);
            testes.Add(novoTeste);
            return novoTeste;
        }

        public bool ExcluirTeste(int id)
        {
            var teste = testes.FirstOrDefault(t => t.Id == id);
            if (teste == null)
            {
                return false;
            }

            testes.Remove(teste);
            return true;
        }

        public List<Teste> ListarTestes()
        {
            return testes;
        }

        public Teste ObterDetalhesTeste(int id)
        {
            return testes.FirstOrDefault(t => t.Id == id);
        }
    }
}