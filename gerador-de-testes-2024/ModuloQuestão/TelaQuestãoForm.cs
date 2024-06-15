using gerador_de_testes_2024.WinApp.Compartilhado;
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
<<<<<<< Updated upstream:gerador-de-testes-2024/ModuloQuestão/TelaQuestãoForm.cs
    public partial class TelaQuestãoForm : Form
=======
    public partial class TabelaQuestaoControl : UserControl
>>>>>>> Stashed changes:gerador-de-testes-2024/ModuloQuestão/TabelaQuestaoControl.cs
    {
        public TelaQuestãoForm()
        {
            InitializeComponent();

            gridQuestao.Columns.AddRange(ObterColunas());
            gridQuestao.ConfigurarGridSomenteLeitura();
            gridQuestao.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            gridQuestao.Rows.Clear();

            foreach (var q in questoes)
                gridQuestao.Rows.Add(q.Id, q.materia.ToTitleCase(), q.serie, q.alternativaCorreta, q.alternativaA, q.alternativaB, q.alternativaC, q.alternativaD, q.enunciado);
        }

        public int ObertRegistroSelecionado()
        {
            return gridQuestao.SelecionarId();
        }

        internal int ObterRegistroSelecionado()
        {
            throw new NotImplementedException();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" }
            };
        }
    }
}
