﻿namespace gerador_de_testes2024.Compartilhado;

public abstract class EntidadeBase
{
    public int Id { get; set; }

    public abstract List<string> Validar();

    public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
}