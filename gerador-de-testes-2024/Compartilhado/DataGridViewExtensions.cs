namespace gerador_de_testes_2024.WinApp.Compartilhado;

public static class DataGridViewExtensions
{
    public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AutoGenerateColumns = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BorderStyle = BorderStyle.None;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grid.MultiSelect = false;
        grid.ReadOnly = true;
        grid.RowHeadersVisible = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    public static void ConfigurarGridZebrado(this DataGridView grid)
    {
        var font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

        var linhaClara = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            Font = font,
            SelectionBackColor = Color.LightYellow,
            SelectionForeColor = Color.Black
        };

        var linhaEscura = new DataGridViewCellStyle
        {
            BackColor = Color.LightGray,
            Font = font,
            ForeColor = Color.Black,
            SelectionBackColor = Color.LightYellow,
            SelectionForeColor = Color.Black
        };

        grid.RowsDefaultCellStyle = linhaClara;
        grid.AlternatingRowsDefaultCellStyle = linhaEscura;
    }

    public static int SelecionarId(this DataGridView grid)
    {
        if (grid.SelectedRows.Count == 0)
            return -1;

        var valorSelecionado = grid
            .SelectedRows[0]
            .Cells[0]
            .Value;

        if (valorSelecionado == null)
            return -1;

        return (int)valorSelecionado;
    }
}