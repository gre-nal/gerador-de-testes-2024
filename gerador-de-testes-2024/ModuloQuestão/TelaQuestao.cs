using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerador_de_testes_2024.WinApp.Compartilhado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace gerador_de_testes_2024.ModuloQuestão
{
    public partial class TelaQuestao : Form
    {
        public TelaQuestao()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e, string materia, string enunciado, string respostaCorreta,
            string alternativaA, string alternativaB, string alternativaC, string alternativaD, int botoesRemovidos)
        {
            materia = comboBoxMateria.Text;
            enunciado = textBoxEnunciado.Text;
            respostaCorreta = comboBoxResposta.Text;
            alternativaA = textBoxAlternativaA.Text;
            alternativaB = textBoxAlternativaB.Text;
            alternativaC = textBoxAlternativaC.Text;
            alternativaD = textBoxAlternativaD.Text;
        }

        private void buttonRemover_Click(object sender, EventArgs e, string alternativaC, string AlternativaD, int botoesRemovidos)
        {
            if (botoesRemovidos == 0)
            {
                this.Controls.Remove(textBoxAlternativaD);
                this.Controls.Remove(labelD);
                comboBoxResposta.Items.AddRange(["A", "B", "C"]);
                botoesRemovidos++;
            }
            else if (botoesRemovidos == 1)
            {
                this.Controls.Remove(textBoxAlternativaC);
                this.Controls.Remove(labelC);
                comboBoxResposta.Items.AddRange(["A", "B"]);
                botoesRemovidos++;
            }
            else
            {
                MessageBox.Show("Não é possível remover mais nenhuma alternativa");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e, string serie)
        {
            serie = "1º série";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e, string serie)
        {
            serie = "2º série";
        }
    }
}
