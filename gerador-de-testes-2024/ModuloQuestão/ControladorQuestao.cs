using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloQuestao;
using gerador_de_testes_2024.ModuloQuestão;

namespace gerador_de_testes_2024.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string TipoCadastro => "Questões";

        public override string ToolTipAdicionar => "Cadastrar uma nova questão";

        public override string ToolTipEditar => "Editar uma questão";

        public override string ToolTipExcluir => "Excluir questão";

        public override void Adicionar()
        {
            var novaQuestao = ObterDadosQuestaoDoUsuario();

            if (novaQuestao == null) return;

            repositorioQuestao.Cadastrar(novaQuestao);
        }

        private Questao ObterDadosQuestaoDoUsuario()
        {
            var novaQuestao = new Questao
            {
                Id = repositorioQuestao.PegarId(),
                Enunciado = "Enunciado da questão",
                Materia = "Matéria da questão"
            };

            return novaQuestao;
        }

        public override void Editar()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (SemSeleção(questaoSelecionada)) return;

            var dadosAtualizados = ObterDadosAtualizadosDoUsuario(questaoSelecionada);

            if (dadosAtualizados == null) return;

            repositorioQuestao.Editar(questaoSelecionada.Id, dadosAtualizados);
        }

        private Questao ObterDadosAtualizadosDoUsuario(Questao questaoAtual)
        {
            questaoAtual.Enunciado = "Novo enunciado da Questão";
            questaoAtual.Materia = "Nova matéria da questão";

            return questaoAtual;
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (SemSeleção(questaoSelecionada)) return;
            if (!DesejaRealmenteExcluir(questaoSelecionada)) return;
            repositorioQuestao.Excluir(questaoSelecionada.Id);
        }
    }
}
