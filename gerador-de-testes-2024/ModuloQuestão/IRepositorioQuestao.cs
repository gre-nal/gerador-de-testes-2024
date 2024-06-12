using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_de_testes_2024.ModuloQuestão
{
    internal interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);
        bool Editar(int id, Questao QuestaoEditado);
        bool Excluir(int id);
        Questao SelecionarPorId(int idSelecionado);
        List<Questao> SelecionarTodos();
        int PegarId();
        void Atualizar();
    }
}
