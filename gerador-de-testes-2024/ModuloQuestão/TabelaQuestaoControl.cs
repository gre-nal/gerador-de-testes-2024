using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloQuestao;

namespace gerador_de_testes_2024.ModuloQuestão
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Questao> questaos)
        {
            gridQuestao.Rows.Clear();

            foreach (var q in questaos)
            {
                gridQuestao.Rows.Add(q.Id, q.Enunciado,q.Alternativas,q.Materia);
            }
        }
        public int ObterRegistroSelecionado()
        {
            return gridQuestao.SelecionarId();
        }
    }
}
