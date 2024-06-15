using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace gerador_de_testes_2024.ModuloMatéria
{
    public partial class TabelaMateriaControl : System.Windows.Forms.UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Materia> materias)
        {
            GridMateria.Rows.Clear();

            foreach (var m in materias)
                GridMateria.Rows.Add(m.Id, m.Serie, m.Disciplina, m.Nome);
        }

        public int ObertRegistroSelecionado()
        {
            return GridMateria.SelecionarId();
        }
    }
}
