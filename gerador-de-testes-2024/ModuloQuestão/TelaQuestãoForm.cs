using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloMateria;
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

            public void AtualizarRegistros(List<Questao> questaos)
            {
                foreach (var q in questaos)
                    .Rows.Add(m.Id);
            }

            public int ObertRegistroSelecionado()
            {
                return gridQuestao.SelecionarId();
            }

            internal int ObterRegistroSelecionado()
            {
                throw new NotImplementedException();
            }
        }
    }
