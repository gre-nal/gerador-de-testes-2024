namespace gerador_de_testes_2024.ModuloQuestão
{
    partial class TelaQuestãoForm
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
            lblMateria = new Label();
            lblEnunciado = new Label();
            lblResposta = new Label();
            btnAdicionar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            checkA = new CheckBox();
            checkB = new CheckBox();
            checkC = new CheckBox();
            checkBox1 = new CheckBox();
            btnRemover = new FontAwesome.Sharp.IconButton();
            cmbMateria = new ComboBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtD = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOK.IconColor = Color.Black;
            btnOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOK.Location = new Point(252, 314);
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
            btnCancelar.Location = new Point(359, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 87);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(22, 20);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Matéria:";
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.Location = new Point(12, 63);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(66, 15);
            lblEnunciado.TabIndex = 3;
            lblEnunciado.Text = "Enunciado:";
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(18, 125);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(57, 15);
            lblResposta.TabIndex = 4;
            lblResposta.Text = "Resposta:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAdicionar.IconColor = Color.Black;
            btnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdicionar.Location = new Point(394, 99);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(66, 66);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtD);
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkC);
            groupBox1.Controls.Add(checkB);
            groupBox1.Controls.Add(checkA);
            groupBox1.Location = new Point(22, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 214);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas:";
            // 
            // checkA
            // 
            checkA.AutoSize = true;
            checkA.Location = new Point(6, 27);
            checkA.Name = "checkA";
            checkA.Size = new Size(15, 14);
            checkA.TabIndex = 7;
            checkA.UseVisualStyleBackColor = true;
            // 
            // checkB
            // 
            checkB.AutoSize = true;
            checkB.Location = new Point(6, 56);
            checkB.Name = "checkB";
            checkB.Size = new Size(15, 14);
            checkB.TabIndex = 8;
            checkB.UseVisualStyleBackColor = true;
            // 
            // checkC
            // 
            checkC.AutoSize = true;
            checkC.Location = new Point(6, 94);
            checkC.Name = "checkC";
            checkC.Size = new Size(15, 14);
            checkC.TabIndex = 9;
            checkC.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnRemover.IconColor = Color.Black;
            btnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemover.Location = new Point(6, 154);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 54);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(94, 12);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(94, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(294, 49);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(94, 99);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(294, 66);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // txtA
            // 
            txtA.Location = new Point(27, 23);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 11;
            // 
            // txtB
            // 
            txtB.Location = new Point(27, 52);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 12;
            // 
            // txtC
            // 
            txtC.Location = new Point(27, 90);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 13;
            // 
            // txtD
            // 
            txtD.Location = new Point(27, 124);
            txtD.Name = "txtD";
            txtD.Size = new Size(100, 23);
            txtD.TabIndex = 14;
            // 
            // TelaQuestãoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 406);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(cmbMateria);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(lblResposta);
            Controls.Add(lblEnunciado);
            Controls.Add(lblMateria);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Name = "TelaQuestãoForm";
            Text = "Cadastro de Questões";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnOK;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label lblMateria;
        private Label lblEnunciado;
        private Label lblResposta;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private GroupBox groupBox1;
        private CheckBox checkA;
        private FontAwesome.Sharp.IconButton btnRemover;
        private CheckBox checkBox1;
        private CheckBox checkC;
        private CheckBox checkB;
        private ComboBox cmbMateria;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
    }
}