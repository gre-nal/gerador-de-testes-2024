namespace gerador_de_testes_2024.ModuloMatéria
{
    partial class TelaMateriaForm
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
            lblID = new Label();
            lblNomeDisciplina = new Label();
            btnOK = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            lblDisciplina = new Label();
            lblSerie = new Label();
            cmbDisciplina = new ComboBox();
            rdbPrimeira = new RadioButton();
            rdbSegunda = new RadioButton();
            txtNome = new TextBox();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(52, 28);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblNomeDisciplina
            // 
            lblNomeDisciplina.AutoSize = true;
            lblNomeDisciplina.Location = new Point(30, 63);
            lblNomeDisciplina.Name = "lblNomeDisciplina";
            lblNomeDisciplina.Size = new Size(43, 15);
            lblNomeDisciplina.TabIndex = 1;
            lblNomeDisciplina.Text = "Nome:";
            // 
            // btnOK
            // 
            btnOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOK.IconColor = Color.Black;
            btnOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOK.Location = new Point(12, 185);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(101, 87);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(152, 185);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 87);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(12, 105);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(61, 15);
            lblDisciplina.TabIndex = 4;
            lblDisciplina.Text = "Disciplina:";
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(12, 144);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(35, 15);
            lblSerie.TabIndex = 5;
            lblSerie.Text = "Série:";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(79, 97);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(174, 23);
            cmbDisciplina.TabIndex = 6;
            // 
            // rdbPrimeira
            // 
            rdbPrimeira.AutoSize = true;
            rdbPrimeira.Location = new Point(50, 144);
            rdbPrimeira.Name = "rdbPrimeira";
            rdbPrimeira.Size = new Size(96, 19);
            rdbPrimeira.TabIndex = 7;
            rdbPrimeira.TabStop = true;
            rdbPrimeira.Text = "Primeira série";
            rdbPrimeira.UseVisualStyleBackColor = true;
            // 
            // rdbSegunda
            // 
            rdbSegunda.AutoSize = true;
            rdbSegunda.Location = new Point(152, 144);
            rdbSegunda.Name = "rdbSegunda";
            rdbSegunda.Size = new Size(98, 19);
            rdbSegunda.TabIndex = 8;
            rdbSegunda.TabStop = true;
            rdbSegunda.Text = "Segunda série";
            rdbSegunda.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 23);
            txtNome.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(79, 20);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 10;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 284);
            Controls.Add(txtID);
            Controls.Add(txtNome);
            Controls.Add(rdbSegunda);
            Controls.Add(rdbPrimeira);
            Controls.Add(cmbDisciplina);
            Controls.Add(lblSerie);
            Controls.Add(lblDisciplina);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(lblNomeDisciplina);
            Controls.Add(lblID);
            Name = "TelaMateriaForm";
            Text = "Cadastro de Matérias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblNomeDisciplina;
        private FontAwesome.Sharp.IconButton btnOK;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label lblDisciplina;
        private Label lblSerie;
        private ComboBox cmbDisciplina;
        private RadioButton rdbPrimeira;
        private RadioButton rdbSegunda;
        private TextBox txtNome;
        private TextBox txtID;
    }
}