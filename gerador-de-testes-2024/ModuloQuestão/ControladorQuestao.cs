using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloQuestao;

namespace gerador_de_testes_2024.ModuloQuestão
{
    public class ControladorQuestao(IRepositorioQuestao repositorioQuestao) : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao = repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;

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
                Materia = "Mateira da questão"
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
            questaoAtual.Materia = "Nova matéria da questao";

            return questaoAtual;
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var questaoSelecionado = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (SemSeleção(questaoSelecionado)) return;
            if (!DesejaRealmenteExcluir(questaoSelecionado)) return;
            repositorioQuestao.Excluir(questaoSelecionado.id);
                     
        }
    }
}
