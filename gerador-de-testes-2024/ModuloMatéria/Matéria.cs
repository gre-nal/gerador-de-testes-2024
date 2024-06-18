using gerador_de_testes_2024.Compartilhado;

namespace gerador_de_testes_2024.ModuloMateria
{
    public class Materia : EntidadeBase
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

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            var atualizado = (Materia)novoRegistro;

            Id = atualizado.Id;
            Nome = atualizado.Nome;
            Disciplina = atualizado.Disciplina;
            Serie = atualizado.Serie;
        }

        public override List<string> Validar()
        {
            var erros = new List<string>();

            VerificarNulo(ref erros, Id, "Id");
            VerificarNulo(ref erros, Nome, "Nome");
            VerificarNulo(ref erros, Disciplina, "Disciplina");
            VerificarNulo(ref erros, Serie, "Série");


            return erros;
        }
        protected void VerificarNulo(ref List<string> erros, Materia campoTestado)
        {
            if (campoTestado == null)
                erros.Add($"É necessário informar um {campoTestado}. Tente novamente ");
        }
    }
}