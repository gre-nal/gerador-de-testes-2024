using gerador_de_testes2024.Compartilhado;

namespace gerador_de_testes2024.ModuloDisciplina;

public partial class TabelaDisciplinaControl : UserControl
{
    public TabelaDisciplinaControl()
    {
        InitializeComponent();

        grid.Columns.AddRange(ObterColunas());

        grid.ConfigurarGridSomenteLeitura();
        grid.ConfigurarGridZebrado();
    }

    public void AtualizarRegistros(List<Disciplina> disciplinas)
    {
        grid.Rows.Clear();

        foreach (var disciplina in disciplinas)
            grid.Rows.Add(disciplina.Id, disciplina.Nome);
    }

    public int ObterRegistroSelecionado()
    {
        return grid.SelecionarId();
    }

    private DataGridViewColumn[] ObterColunas()
    {
        return new DataGridViewColumn[]
        {
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
        };
    }
}