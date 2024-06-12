﻿namespace gerador_de_testes_2024.Compartilhado;

public abstract class RepositorioBaseEmMemoria<T> where T : EntidadeBase
{
    protected int contadorId = 1;
    protected List<T> registros = new();

    public void Atualizar()
    {
    }

    public void Cadastrar(T novoRegistro)
    {
        novoRegistro.Id = contadorId++;
        registros.Add(novoRegistro);
    }

    public bool Editar(int id, T novaEntidade)
    {
        var registro = SelecionarPorId(id);

        if (registro == null)
            return false;

        registro.AtualizarRegistro(novaEntidade);
        return true;
    }

    public bool Excluir(int id)
    {
        return registros.Remove(SelecionarPorId(id));
    }

    public bool Existe(int id)
    {
        return registros.Any(x => x.Id == id);
    }

    public int PegarId()
    {
        return contadorId;
    }

    public List<T> SelecionarTodos()
    {
        return registros;
    }

    public T SelecionarPorId(int id)
    {
        return registros.Find(x => x.Id == id);
    }
}