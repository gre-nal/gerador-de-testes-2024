namespace gerador_de_testes_2024.ModuloMateria
{
    public class ControladorMateria
    {
        private List<Materia> materias = new List<Materia>();
        private int ultimoId = 0;

        public bool AdicionarMateria(string nome, string disciplina, string serie)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(disciplina) ||
                string.IsNullOrWhiteSpace(serie) ||
                materias.Any(m => m.Nome == nome))
            {
                return false;
            }

            materias.Add(new Materia(++ultimoId, nome, disciplina, serie));
            return true;
        }

        public bool EditarMateria(int id, string novoNome, string novaDisciplina, string novaSerie)
        {
            var materia = materias.FirstOrDefault(m => m.Id == id);
            if (materia == null || string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novaDisciplina) ||
                string.IsNullOrWhiteSpace(novaSerie) ||
                materias.Any(m => m.Nome == novoNome && m.Id != id))
            {
                return false;
            }

            materia.Nome = novoNome;
            materia.Disciplina = novaDisciplina;
            materia.Serie = novaSerie;
            return true;
        }

        public bool ExcluirMateria(int id)
        {
            var materia = materias.FirstOrDefault(m => m.Id == id);
            // Aqui você precisaria verificar se a materia está sendo usada em um teste antes de excluir
            if (materia == null /* || questão está sendo usada em um teste */)
            {
                return false;
            }

            materias.Remove(materia);
            return true;
        }

        public List<Materia> ListarMaterias()
        {
            return materias;
        }
    }
}