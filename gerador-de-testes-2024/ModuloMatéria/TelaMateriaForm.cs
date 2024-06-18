using gerador_de_testes_2024.ModuloMateria;
using gerador_de_testes_2024.Compartilhado;

namespace gerador_de_testes_2024.ModuloMatéria
{
    public partial class TelaMateriaForm : Form
    {
        public TelaMateriaForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e, string nome, string disciplina)
        {
            nome = txtNome.Text;
            disciplina = cmbDisciplina.Text; 
        }
        private void RdbSegunda_Click(object sender, EventArgs e, string serie)
        {
            serie = "2º série"; 
        }

        private void RdbPrimeira_Click(object sender, EventArgs e, string serie)
        {
            serie = "1º série";
        }
    }
}
