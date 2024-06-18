using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerador_de_testes_2024.ModuloQuestão
{
    public partial class TelaQuestãoForm : Form
    {
        public TelaQuestãoForm()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e, List<Alternativa> Alternativas)
        {
            int contadorRemove = 0;
            Alternativa alternativaParaRemover = Alternativas.FirstOrDefault(a => a.Id == contadorRemove);

            if (alternativaParaRemover != null)
            {
                Alternativas.Remove(alternativaParaRemover);
                Console.WriteLine("Alternativa removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Alternativa não encontrada.");
            }
        }
        private void BtnOK_Click(object sender, EventArgs e, List<Alternativa> Alternativas, string Enunciado, string Materia, string Texto, string Corrta)
        {
            
        }
    }
}
