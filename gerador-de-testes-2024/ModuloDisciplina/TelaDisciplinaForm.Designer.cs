namespace gerador_de_testes2024.ModuloDisciplina
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
            labelNome = new Label();
            txtNomeDisciplina = new TextBox();
            btnGravar = new Button();
            button2 = new Button();
            lblId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 55);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(61, 52);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(235, 23);
            txtNomeDisciplina.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(61, 81);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(81, 26);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(236, 164);
            button2.Name = "button2";
            button2.Size = new Size(81, 26);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(17, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 6;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(61, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(81, 23);
            txtId.TabIndex = 7;
            // 
            // TelaDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 202);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(labelNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDisciplinaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Disciplinas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNome;
        private TextBox txtNomeDisciplina;
        private Button btnGravar;
        private Button button2;
        private Label lblId;
        private TextBox txtId;
    }
}