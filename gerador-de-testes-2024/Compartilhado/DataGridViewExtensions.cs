﻿namespace gerador_de_testes2024.Compartilhado;

public static class DataGridViewExtensions
{
    public static void ConfigurarGridZebrado(this DataGridView grid)
    {
        var font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

        var linhaEscura = new DataGridViewCellStyle
        {
            BackColor = Color.LightGray,
            Font = font,
            ForeColor = Color.Black,
            SelectionBackColor = Color.LightYellow,
            SelectionForeColor = Color.Black
        };

        grid.AlternatingRowsDefaultCellStyle = linhaEscura;

        var linhaClara = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            Font = font,
            SelectionBackColor = Color.LightYellow,
            SelectionForeColor = Color.Black
        };

        grid.RowsDefaultCellStyle = linhaClara;
    }

    public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
    {
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;

        grid.BorderStyle = BorderStyle.None;

        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        grid.MultiSelect = false;
        grid.ReadOnly = true;

        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoGenerateColumns = false;

        grid.AllowUserToResizeRows = false;
        grid.RowHeadersVisible = false;
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