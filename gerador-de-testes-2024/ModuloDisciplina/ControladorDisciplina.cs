namespace gerador_de_testes_2024.ModuloDisciplina
{
    public class ControladorDisciplina
    {
        private List<Disciplina> disciplinas = new List<Disciplina>();
        private int ultimoId = 0;

        public bool AdicionarDisciplina(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || disciplinas.Any(d => d.Nome == nome))
            {
                return false;
            }

            disciplinas.Add(new Disciplina(++ultimoId, nome));
            return true;
        }

        public bool EditarDisciplina(int id, string novoNome)
        {
            var disciplina = disciplinas.FirstOrDefault(d => d.Id == id);
            if (disciplina == null || string.IsNullOrWhiteSpace(novoNome) ||
                disciplinas.Any(d => d.Nome == novoNome && d.Id != id))
            {
                return false;
            }

            disciplina.Nome = novoNome;
            return true;
        }

        public bool ExcluirDisciplina(int id)
        {
            var disciplina = disciplinas.FirstOrDefault(d => d.Id == id);
            if (disciplina == null || disciplina.Materias.Any())
            {
                return false;
            }

            disciplinas.Remove(disciplina);
            return true;
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return disciplinas;
        }
    }
}