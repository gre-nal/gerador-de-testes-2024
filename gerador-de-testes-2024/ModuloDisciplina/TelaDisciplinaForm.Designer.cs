namespace gerador_de_testes_2024.ModuloDisciplina
{
    partial class TelaDisciplinaForm
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
            lblId = new Label();
            lblNomeDisciplina = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            btnOk = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(34, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNomeDisciplina
            // 
            lblNomeDisciplina.AutoSize = true;
            lblNomeDisciplina.Location = new Point(12, 53);
            lblNomeDisciplina.Name = "lblNomeDisciplina";
            lblNomeDisciplina.Size = new Size(43, 15);
            lblNomeDisciplina.TabIndex = 1;
            lblNomeDisciplina.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Location = new Point(61, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 23);
            txtNome.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOk.IconColor = Color.Black;
            btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOk.Location = new Point(61, 79);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 63);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(261, 79);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 63);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 152);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblNomeDisciplina);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Cadastro de Disciplinas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNomeDisciplina;
        private TextBox txtId;
        private TextBox txtNome;
        private FontAwesome.Sharp.IconButton btnOk;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}