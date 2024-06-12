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
            var id = repositorioQuestao.();

            var telaQuestao = new TelaQuestaoForm(id);
            var resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novoItem = telaItem.Item;

            RealizarAção(
                () => repositorioItem.Cadastrar(novoItem),
                novoItem, "criado");

            id++;
        }

        public override void Editar()
        {
            var idSelecionado = tabelaItens.ObterRegistroSelecionado();

            var telaItem = new TelaItemForm(idSelecionado);

            var itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (NoSelection(itemSelecionado)) return;

            telaItem.Item = itemSelecionado;

            var resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var temaEditado = telaItem.Item;

            RealizarAção(
                () => repositorioItem.Editar(itemSelecionado.Id, temaEditado),
                temaEditado, "editado");
        }

        public override void Excluir()
        {
            var idSelecionado = tabelaItens.ObterRegistroSelecionado();

            var itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (NoSelection(itemSelecionado)) return;

            var resposta = MessageBox.Show(
                $"Excluir o registro \"{itemSelecionado.Descrição}\"?",
                "OK",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return;

            itemSelecionado.Valor = 0;

            RealizarAção(
                () => repositorioItem.Excluir(itemSelecionado.Id),
                itemSelecionado, "excluído");
        }

        public override UserControl ObterListagem()
        {
            tabelaItens ??= new TabelaItemControl();

            CarregarItems();
            return tabelaItens;
        }

        private void CarregarItems()
        {
            var itens = repositorioItem.SelecionarTodos();

            tabelaItens.AtualizarRegistros(itens);
        }

        private void CarregarMensagem(Item item, string texto)
        {
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{item.Descrição}\" foi {texto} com sucesso!");
        }

        private void RealizarAção(Action acao, Item tema, string texto)
        {
            acao();
            CarregarItems();
            CarregarMensagem(tema, texto);
        }

        private bool NoSelection(Item item)
        {
            return item == null;
        }

    }
}
