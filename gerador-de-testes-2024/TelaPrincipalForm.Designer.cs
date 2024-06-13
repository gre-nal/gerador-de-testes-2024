namespace gerador_de_testes_2024
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelButtons = new Panel();
            groupBoxButtons = new GroupBox();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnVisualizar = new FontAwesome.Sharp.IconButton();
            btnExcluir = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAdicionar = new FontAwesome.Sharp.IconButton();
            pnlTestesGerados = new Panel();
            menuModulos = new MenuStrip();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            matériasToolStripMenuItem = new ToolStripMenuItem();
            questõesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            panelButtons.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            pnlTestesGerados.SuspendLayout();
            menuModulos.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(groupBoxButtons);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(727, 100);
            panelButtons.TabIndex = 0;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(tableLayoutPanelButtons);
            groupBoxButtons.Dock = DockStyle.Fill;
            groupBoxButtons.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxButtons.Location = new Point(0, 0);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(727, 100);
            groupBoxButtons.TabIndex = 1;
            groupBoxButtons.TabStop = false;
            groupBoxButtons.Text = "Ações";
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 4;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelButtons.Controls.Add(btnVisualizar, 3, 0);
            tableLayoutPanelButtons.Controls.Add(btnExcluir, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnEditar, 1, 0);
            tableLayoutPanelButtons.Controls.Add(btnAdicionar, 0, 0);
            tableLayoutPanelButtons.Location = new Point(12, 28);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(703, 66);
            tableLayoutPanelButtons.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            btnVisualizar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnVisualizar.IconColor = Color.Black;
            btnVisualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVisualizar.Location = new Point(528, 3);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(172, 60);
            btnVisualizar.TabIndex = 3;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btnExcluir.IconColor = Color.Black;
            btnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluir.Location = new Point(353, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(169, 60);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(178, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(169, 60);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAdicionar.IconColor = Color.Black;
            btnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdicionar.Location = new Point(3, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(169, 60);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // pnlTestesGerados
            // 
            pnlTestesGerados.BackColor = SystemColors.Control;
            pnlTestesGerados.Controls.Add(menuModulos);
            pnlTestesGerados.Location = new Point(12, 106);
            pnlTestesGerados.Name = "pnlTestesGerados";
            pnlTestesGerados.Size = new Size(703, 332);
            pnlTestesGerados.TabIndex = 1;
            // 
            // menuModulos
            // 
            menuModulos.Items.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, matériasToolStripMenuItem, questõesToolStripMenuItem, testesToolStripMenuItem });
            menuModulos.Location = new Point(0, 0);
            menuModulos.Name = "menuModulos";
            menuModulos.Size = new Size(703, 24);
            menuModulos.TabIndex = 0;
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(75, 20);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            // 
            // matériasToolStripMenuItem
            // 
            matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            matériasToolStripMenuItem.Size = new Size(64, 20);
            matériasToolStripMenuItem.Text = "Matérias";
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(68, 20);
            questõesToolStripMenuItem.Text = "Questões";
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(50, 20);
            testesToolStripMenuItem.Text = "Testes";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(727, 450);
            Controls.Add(pnlTestesGerados);
            Controls.Add(panelButtons);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaPrincipalForm";
            Text = "Gerador de Testes";
            panelButtons.ResumeLayout(false);
            groupBoxButtons.ResumeLayout(false);
            tableLayoutPanelButtons.ResumeLayout(false);
            pnlTestesGerados.ResumeLayout(false);
            pnlTestesGerados.PerformLayout();
            menuModulos.ResumeLayout(false);
            menuModulos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private GroupBox groupBoxButtons;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private TableLayoutPanel tableLayoutPanelButtons;
        private FontAwesome.Sharp.IconButton btnVisualizar;
        private FontAwesome.Sharp.IconButton btnExcluir;
        private FontAwesome.Sharp.IconButton btnEditar;
        private Panel pnlTestesGerados;
        private MenuStrip menuModulos;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem matériasToolStripMenuItem;
        private ToolStripMenuItem questõesToolStripMenuItem;
        private ToolStripMenuItem testesToolStripMenuItem;
    }
}
