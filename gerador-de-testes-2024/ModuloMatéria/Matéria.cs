namespace gerador_de_testes_2024.ModuloMateria
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string Serie { get; set; }

        public Materia(int id, string nome, string disciplina, string serie)
        {
            Id = id;
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }
    }
}