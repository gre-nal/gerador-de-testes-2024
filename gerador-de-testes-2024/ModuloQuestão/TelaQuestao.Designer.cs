namespace gerador_de_testes_2024.ModuloQuestão
{
    partial class TelaQuestao
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
            labelMateria = new Label();
            labelEnunciado = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAdicionar = new Button();
            groupBoxAlternativas = new GroupBox();
            buttonRemover = new Button();
            buttonCancelar = new Button();
            buttonGravar = new Button();
            checkBoxA = new CheckBox();
            checkBoxB = new CheckBox();
            checkBoxC = new CheckBox();
            checkBoxD = new CheckBox();
            groupBoxAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.ImageAlign = ContentAlignment.MiddleRight;
            labelMateria.Location = new Point(35, 54);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(50, 15);
            labelMateria.TabIndex = 0;
            labelMateria.Text = "Matéria:";
            // 
            // labelEnunciado
            // 
            labelEnunciado.AutoSize = true;
            labelEnunciado.ImageAlign = ContentAlignment.MiddleRight;
            labelEnunciado.Location = new Point(19, 127);
            labelEnunciado.Name = "labelEnunciado";
            labelEnunciado.Size = new Size(66, 15);
            labelEnunciado.TabIndex = 1;
            labelEnunciado.Text = "Enunciado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(28, 202);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Resposta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 69);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 199);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 31);
            textBox2.TabIndex = 4;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(333, 202);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 31);
            buttonAdicionar.TabIndex = 5;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // groupBoxAlternativas
            // 
            groupBoxAlternativas.Controls.Add(checkBoxD);
            groupBoxAlternativas.Controls.Add(checkBoxC);
            groupBoxAlternativas.Controls.Add(checkBoxB);
            groupBoxAlternativas.Controls.Add(checkBoxA);
            groupBoxAlternativas.Controls.Add(buttonRemover);
            groupBoxAlternativas.Location = new Point(35, 270);
            groupBoxAlternativas.Name = "groupBoxAlternativas";
            groupBoxAlternativas.Size = new Size(373, 204);
            groupBoxAlternativas.TabIndex = 6;
            groupBoxAlternativas.TabStop = false;
            groupBoxAlternativas.Text = "Alternativas:";
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(6, 22);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 31);
            buttonRemover.TabIndex = 9;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(359, 537);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 31);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(278, 537);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 31);
            buttonGravar.TabIndex = 8;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            checkBoxA.AutoSize = true;
            checkBoxA.Location = new Point(6, 59);
            checkBoxA.Name = "checkBoxA";
            checkBoxA.Size = new Size(38, 19);
            checkBoxA.TabIndex = 10;
            checkBoxA.Text = "A)";
            checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            checkBoxB.AutoSize = true;
            checkBoxB.Location = new Point(6, 84);
            checkBoxB.Name = "checkBoxB";
            checkBoxB.Size = new Size(37, 19);
            checkBoxB.TabIndex = 11;
            checkBoxB.Text = "B)";
            checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            checkBoxC.AutoSize = true;
            checkBoxC.Location = new Point(6, 109);
            checkBoxC.Name = "checkBoxC";
            checkBoxC.Size = new Size(38, 19);
            checkBoxC.TabIndex = 12;
            checkBoxC.Text = "C)";
            checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxD
            // 
            checkBoxD.AutoSize = true;
            checkBoxD.Location = new Point(6, 134);
            checkBoxD.Name = "checkBoxD";
            checkBoxD.Size = new Size(38, 19);
            checkBoxD.TabIndex = 13;
            checkBoxD.Text = "D)";
            checkBoxD.UseVisualStyleBackColor = true;
            // 
            // TelaQuestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 580);
            Controls.Add(buttonGravar);
            Controls.Add(buttonCancelar);
            Controls.Add(groupBoxAlternativas);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(labelEnunciado);
            Controls.Add(labelMateria);
            Name = "TelaQuestao";
            Text = "TelaQuestao";
            groupBoxAlternativas.ResumeLayout(false);
            groupBoxAlternativas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMateria;
        private Label labelEnunciado;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAdicionar;
        private GroupBox groupBoxAlternativas;
        private Button buttonRemover;
        private Button buttonCancelar;
        private Button buttonGravar;
        private CheckBox checkBoxA;
        private CheckBox checkBoxD;
        private CheckBox checkBoxC;
        private CheckBox checkBoxB;
    }
}