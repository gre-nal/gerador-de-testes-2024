﻿namespace gerador_de_testes2024.ModuloQuestao;

public interface IRepositorioQuestao
{
    void Cadastrar(Questao novoQuestao);
    bool Editar(int id, Questao questaoEditado);
    bool Excluir(int id);
    Questao SelecionarPorId(int id);
    List<Questao> SelecionarTodos();
}