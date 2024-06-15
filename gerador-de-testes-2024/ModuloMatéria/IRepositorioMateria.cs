using gerador_de_testes_2024.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_de_testes_2024.ModuloMatéria
{
    public interface IRepositorioMateria
    {
        void Atualizar();
        void Cadastrar(Materia novaMateria);
        bool Editar(int id, Materia novaMateria);
        bool Excluir (int id);
        int PegarId();
        Materia SelecionarPorId(int idSelecionado);
        List<Materia> SelecionarTodos();
    }
}
