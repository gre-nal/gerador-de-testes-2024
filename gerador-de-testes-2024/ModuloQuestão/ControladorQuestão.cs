namespace gerador_de_testes_2024.ModuloQuestao
{
    public class ControladorQuestao
    {
        private List<Questao> questoes = new List<Questao>();
        private int ultimoId = 0;

        public bool AdicionarQuestao(string materia, string enunciado, List<Alternativa> alternativas)
        {
            if (string.IsNullOrWhiteSpace(materia) || string.IsNullOrWhiteSpace(enunciado) || alternativas.Count < 2 || alternativas.Count > 4 || alternativas.Count(a => a.Correta) != 1)
            {
                return false;
            }

            var questao = new Questao(++ultimoId, materia, enunciado);
            foreach (var alternativa in alternativas)
            {
                questao.AdicionarAlternativa(alternativa);
            }
            questoes.Add(questao);
            return true;
        }

        public bool EditarQuestao(int id, string novaMateria, string novoEnunciado, List<Alternativa> novasAlternativas)
        {
            var questao = questoes.FirstOrDefault(q => q.Id == id);
            if (questao == null || string.IsNullOrWhiteSpace(novaMateria) || string.IsNullOrWhiteSpace(novoEnunciado) || novasAlternativas.Count < 2 || novasAlternativas.Count > 4 || novasAlternativas.Count(a => a.Correta) != 1)
            {
                return false;
            }

            questao.Materia = novaMateria;
            questao.Enunciado = novoEnunciado;
            questao.Alternativas = novasAlternativas;
            return true;
        }

        public bool ExcluirQuestao(int id)
        {
            var questao = questoes.FirstOrDefault(q => q.Id == id);
            // Aqui você precisaria verificar se a questão está sendo usada em um teste antes de excluir
            if (questao == null /* || questão está sendo usada em um teste */)
            {
                return false;
            }

            questoes.Remove(questao);
            return true;
        }

        public List<Questao> ListarQuestoes()
        {
            return questoes;
        }
    }
}
