namespace gerador_de_testes_2024.WinApp.Compartilhado;

public abstract class ControladorBase
{
    public abstract string TipoCadastro { get; }

    public abstract string ToolTipAdicionar { get; }
    public abstract string ToolTipEditar { get; }
    public abstract string ToolTipExcluir { get; }

    public abstract void Adicionar();
    public abstract void Editar();
    public abstract void Excluir();

    public virtual UserControl ObterListagem()
    {
        return null;
    }

    public virtual UserControl ObterListagemDeAlugueis()
    {
        return null;
    }

    public bool DesejaRealmenteExcluir(EntidadeBase entidadeSelecionada)
    {
        var resposta = MessageBox.Show(
            $"Você deseja realmente excluir o registro \"{entidadeSelecionada}\"?",
            "Confirmar exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (resposta != DialogResult.Yes) return false;
        return true;
    }

    public bool SemSeleção(EntidadeBase entidadeSelecionada)
    {
        if (entidadeSelecionada == null)
        {
            MessageBox.Show(
                "Não é possível realizar esta ação sem um registro selecionado.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return true;
        }

        return false;
    }
}