﻿using gerador_de_testes_2024.Compartilhado;
using gerador_de_testes_2024.ModuloQuestao;

namespace gerador_de_testes_2024.ModuloQuestão
{
    internal class RepositorioQuestaoEmArquivo : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo() : base("Questões.json")
        {
        }

        public void Cadastrar(TelaQuestaoForm novaQuestao)
        {
            throw new NotImplementedException();
        }

        public void Editar(int id, object questaoEditado)
        {
            throw new NotImplementedException();
        }
    }
}
