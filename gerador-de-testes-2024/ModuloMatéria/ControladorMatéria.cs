using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloMatéria;

namespace gerador_de_testes_2024.ModuloMateria
{
    public class ControladorMateria(IRepositorioMateria repositorioMateria) : ControladorBase
    {
        private List<Materia> materias = new List<Materia>();
        private int ultimoId = 0;
        private readonly IRepositorioMateria repositorioMateria = repositorioMateria;
        private TabelaMateriaControl tabelaMateria;
        public override string TipoCadastro => "Matéria";
        public override string ToolTipAdicionar => "Cadastrar uma nova Matéria";
        public override string ToolTipEditar => "Editar uma Matéria";
        public override string ToolTipExcluir => "Excluir Matéria";

        public override void Adicionar()
        {
            var id = repositorioMateria.PegarId();

            var telaMateria = new TelaMateriaForm(id);
            var resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novaMateria = telaMateria;

            repositorioMateria.Cadastrar(novaMateria);
            id++;
        }

        public override void Editar()
        {
            var idSelecionado = tabelaMateria.ObertRegistroSelecionado();
            var telaMateria = new TelaMateriaForm(idSelecionado);
            var materiaSelecionado = repositorioMateria.SelecionarPorId(idSelecionado);

            if(materiaSelecionado == null)
            {
                MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
                return;
            }
            telaMateria = materiaSelecionado;

            var resultado = telaMateria.ShowDialog();
            if (resultado != DialogResult.OK) return;

            var materiaEditado = telaMateria;
            repositorioMateria.Editar(materiaSelecionado.Id, materiaEditado);
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaMateria.ObertRegistroSelecionado();

            var materiaSelecionado = repositorioMateria.SelecionarPorId(idSelecionado);

            if (SemSeleção(materiaSelecionado)) return;

            if (!DesejaRealmenteExcluir(materiaSelecionado)) return;

            repositorioMateria.Excluir(materiaSelecionado.Id);
        }
    }
}