using gerador_de_testes_2024.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_de_testes_2024.ModuloQuestão
{
    internal class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaItens;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string TipoCadastro => "Questões";
        public override string ToolTipAdicionar => "Adicionar novo questão";
        public override string ToolTipEditar => "Editar questao existente";
        public override string ToolTipExcluir => "Excluir questao existente";

        public override void Adicionar()
        {
            var id = repositorioQuestao();

            var telaQuestao = new TelaQuestaoForm(id);
            var resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novoQuestao = telaQuestao;

            RealizarAção(
                () => repositorioQuestao.Cadastrar(novoQuestao),
                novoQuestao, "criado");

            id++;
        }

        public override void Editar()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var telaQuestao = new TelaQuestaoForm(idSelecionado);

            var questaoSelecionado = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (NoSelection(questaoSelecionado)) return;

            telaQuestao.Item = questaoSelecionado;

            var resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var questaoEditado = telaQuestao.Item;

            RealizarAção(
                () => repositorioQuestao.Editar(questaoSelecionado.Id, questaoEditado),
                questaoEditado, "editado");
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            var QuestaoSelecionado = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (NoSelection(QuestaoSelecionado)) return;

            var resposta = MessageBox.Show(
                $"Excluir o registro \"{QuestaoSelecionado.Descrição}\"?",
                "OK",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return;


            RealizarAção(
                () => repositorioQuestao.Excluir(questaoSelecionado.Id),
                QuestaoSelecionado, "excluído");
        }

        public override UserControl ObterListagem()
        {
            tabelaQuestao ??= new TabelaQuestaoControl();

            CarregarItems();
            return tabelaQuestao;
        }

        private void CarregarItems()
        {
            var QuestaoSelecionado = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questao);
        }

        private void CarregarMensagem(Questao questao)
        {
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questao.enunciado}\" foi concluído com sucesso!");
        }

        private void RealizarAção(Action acao, Questao questao)
        {
            acao();
            CarregarItems();
            CarregarMensagem(questao);
        }

        private bool NoSelection(Questao questao)
        {
            return questao == null;
        }

    }
}
