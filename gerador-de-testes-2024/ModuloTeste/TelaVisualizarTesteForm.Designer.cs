﻿namespace gerador_de_testes2024.ModuloTeste
{
    partial class TelaVisualizarTesteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            button1 = new Button();
            txtMateria = new Label();
            txtDisciplina = new Label();
            txtTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 85);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 124);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Location = new Point(14, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 204);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas:";
            // 
            // listQuestoes
            // 
            listQuestoes.Dock = DockStyle.Fill;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(3, 19);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.SelectionMode = SelectionMode.None;
            listQuestoes.Size = new Size(228, 182);
            listQuestoes.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(118, 393);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 1;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtMateria
            // 
            txtMateria.AutoSize = true;
            txtMateria.Location = new Point(84, 124);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(10, 15);
            txtMateria.TabIndex = 5;
            txtMateria.Text = ".";
            // 
            // txtDisciplina
            // 
            txtDisciplina.AutoSize = true;
            txtDisciplina.Location = new Point(84, 85);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(10, 15);
            txtDisciplina.TabIndex = 4;
            txtDisciplina.Text = ".";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Location = new Point(84, 46);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(10, 15);
            txtTitulo.TabIndex = 3;
            txtTitulo.Text = ".";
            // 
            // TelaVisualizarTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(txtMateria);
            Controls.Add(txtDisciplina);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaVisualizarTesteForm";
            Text = "Visualização de Teste";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
        private Button button1;
        private Label txtMateria;
        private Label txtDisciplina;
        private Label txtTitulo;
    }
}