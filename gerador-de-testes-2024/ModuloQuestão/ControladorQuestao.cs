using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerador_de_testes_2024.WinApp.Compartilhado;

namespace gerador_de_testes_2024.ModuloQuestão
{
    internal class ControladorQuestao(IRepositorioQuestao repositorioQuestao) : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao = repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;

        public override string TipoCadastro => "Questões";

        public override string ToolTipAdicionar => "Cadastrar uma nova questão";

        public override string ToolTipEditar => "Editar uma questão";

        public override string ToolTipExcluir => "Excluir questão";

        public override void Adicionar()
        {
            var id = repositorioQuestao.PegarId();

            var telaQuestao = new TelaQuestaoForm(id);
            var resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novaQuestao = telaQuestao;

            repositorioQuestao.Cadastrar(novaQuestao);

            CarregarQuestoes();

            //TelaPrincipalForm
            //    .Instancia
            //    .AtualizarRodape($"A \"questão\" foi criada com sucesso!");

            id++;
        }

        public override void Editar()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var telaQuestao = new TelaQuestaoForm(idSelecionado);

            var questaoSelecionado =
                repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaQuestao = questaoSelecionado;

            var resultado = telaQuestao.ShowDialog();
            if (resultado != DialogResult.OK) return;

            var questaoEditado = telaQuestao;

            repositorioQuestao.Editar(questaoSelecionado.Id, questaoEditado);

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var questaoSelecionado = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (NoSelection(questaoSelecionado)) return;

            var resposta = MessageBox.Show(
                $"Excluir o registro \"{questaoSelecionado.enunciado}\"?",
                "OK",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return;

            RealizarAção(
                () => repositorioQuestao.Excluir(questaoSelecionado.Id),
                questaoSelecionado, "excluído");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }

        private void CarregarQuestoes()
        {
            var Questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(Questoes);
        }
        private bool NoSelection(Questao questao)
        {
            return questao == null;
        }
        private void RealizarAção(Action acao, Questao questao, string texto)
        {
            acao();
            CarregarQuestoes();
            // CarregarMensagem(questao, texto);
        }
    }
}
