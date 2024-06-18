namespace gerador_de_testes_2024.ModuloDisciplina
{
    public class Disciplina
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<string> Materias { get; set; } = new List<string>();

        public Disciplina(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}