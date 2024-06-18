namespace gerador_de_testes_2024.ModuloTeste
{
    partial class TelaTesteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            lblDisciplina = new Label();
            lblMatéria = new Label();
            lblQtdQuestoes = new Label();
            groupBox1 = new GroupBox();
            btnSortearQuestoes = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            listQuestoes = new ListBox();
            txtTitulo = new TextBox();
            cmbDisciplina = new ComboBox();
            cmbMateria = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            checkBoxRecuperacao = new CheckBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOK.IconColor = Color.Black;
            btnOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOK.Location = new Point(218, 476);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(101, 87);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(325, 476);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 87);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(12, 61);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(61, 15);
            lblDisciplina.TabIndex = 3;
            lblDisciplina.Text = "Disciplina:";
            // 
            // lblMatéria
            // 
            lblMatéria.AutoSize = true;
            lblMatéria.Location = new Point(18, 99);
            lblMatéria.Name = "lblMatéria";
            lblMatéria.Size = new Size(50, 15);
            lblMatéria.TabIndex = 4;
            lblMatéria.Text = "Matéria:";
            // 
            // lblQtdQuestoes
            // 
            lblQtdQuestoes.AutoSize = true;
            lblQtdQuestoes.Location = new Point(218, 61);
            lblQtdQuestoes.Name = "lblQtdQuestoes";
            lblQtdQuestoes.Size = new Size(83, 15);
            lblQtdQuestoes.TabIndex = 5;
            lblQtdQuestoes.Text = "Qtd. questões:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortearQuestoes);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 94);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões selecionadas";
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.IconChar = FontAwesome.Sharp.IconChar.Dice;
            btnSortearQuestoes.IconColor = Color.Black;
            btnSortearQuestoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSortearQuestoes.Location = new Point(6, 22);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(188, 56);
            btnSortearQuestoes.TabIndex = 0;
            btnSortearQuestoes.Text = "Sortear questões";
            btnSortearQuestoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(listQuestoes);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 393);
            panel1.TabIndex = 8;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(0, 84);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(200, 304);
            listQuestoes.TabIndex = 7;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(58, 14);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(368, 23);
            txtTitulo.TabIndex = 9;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(79, 53);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(121, 23);
            cmbDisciplina.TabIndex = 10;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(79, 91);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(307, 53);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(119, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // checkBoxRecuperacao
            // 
            checkBoxRecuperacao.AutoSize = true;
            checkBoxRecuperacao.Location = new Point(218, 95);
            checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            checkBoxRecuperacao.Size = new Size(145, 19);
            checkBoxRecuperacao.TabIndex = 13;
            checkBoxRecuperacao.Text = "Prova de recuperação?";
            checkBoxRecuperacao.UseVisualStyleBackColor = true;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 575);
            Controls.Add(checkBoxRecuperacao);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbMateria);
            Controls.Add(cmbDisciplina);
            Controls.Add(txtTitulo);
            Controls.Add(panel1);
            Controls.Add(lblQtdQuestoes);
            Controls.Add(lblMatéria);
            Controls.Add(lblDisciplina);
            Controls.Add(lblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Name = "TelaTesteForm";
            Text = "Cadastro de Testes";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnOK;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label lblTitulo;
        private Label lblDisciplina;
        private Label lblMatéria;
        private Label lblQtdQuestoes;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSortearQuestoes;
        private Panel panel1;
        private ListBox listQuestoes;
        private TextBox txtTitulo;
        private ComboBox cmbDisciplina;
        private ComboBox cmbMateria;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBoxRecuperacao;
    }
}