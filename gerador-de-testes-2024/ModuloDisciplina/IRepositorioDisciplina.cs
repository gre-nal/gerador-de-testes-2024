﻿namespace gerador_de_testes2024.ModuloDisciplina;

public interface IRepositorioDisciplina
{
    void Cadastrar(Disciplina novaDisciplina);
    bool Editar(int id, Disciplina disciplinaEditada);
    bool Excluir(int id);
    Disciplina SelecionarPorId(int id);
    List<Disciplina> SelecionarTodos();
}