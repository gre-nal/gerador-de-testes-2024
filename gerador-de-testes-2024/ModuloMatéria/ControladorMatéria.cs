using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloMatéria;

namespace gerador_de_testes_2024.ModuloMateria
{
    public class ControladorMateria(IRepositorioMateria repositorioMateria) : ControladorBase
    {
        private List<Materia> materias = new List<Materia>();
        public int ultimoId = 0;
        private readonly IRepositorioMateria repositorioMateria = repositorioMateria;
        private TabelaMateriaControl tabelaMateria;
        public override string TipoCadastro => "Matéria";
        public override string ToolTipAdicionar => "Cadastrar uma nova Matéria";
        public override string ToolTipEditar => "Editar uma Matéria";
        public override string ToolTipExcluir => "Excluir Matéria";

        public override void Adicionar()
        {
            var novaMateria = ObterDadosMateriaDoUsuario();

            if (novaMateria == null) return;

            repositorioMateria.Cadastrar(novaMateria);
            materias.Add(novaMateria);
        }

        private Materia ObterDadosMateriaDoUsuario()
        {
            var novaMateria = new Materia
            {
                Id = ultimoId++,
                Nome = "Nome de matéria",
                Disciplina = "Disciplina da matéria",
                Serie = "Série da matéria"
            };

            return novaMateria;
        }

        public override void Editar()
        {
            var idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            var materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (SemSeleção(materiaSelecionada)) return;

            var dadosAtualizados = ObterDadosAtualizadosDoUsuario(materiaSelecionada);

            if (dadosAtualizados == null) return;

            repositorioMateria.Editar(materiaSelecionada.Id, dadosAtualizados);
        }

        private Materia ObterDadosAtualizadosDoUsuario(Materia materiaAtual)
        {
            materiaAtual.Nome = "Novo Nome da Matéria";
            materiaAtual.Serie = "Nova Série da Matéria";

            return materiaAtual;
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            var materiaSelecionado = repositorioMateria.SelecionarPorId(idSelecionado);

            if (SemSeleção(materiaSelecionado)) return;

            if (!DesejaRealmenteExcluir(materiaSelecionado)) return;

            repositorioMateria.Excluir(materiaSelecionado.Id);
        }
    }
}