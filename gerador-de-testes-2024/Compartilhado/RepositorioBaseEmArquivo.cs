namespace gerador_de_testes2024.Compartilhado;

public abstract class RepositorioBaseEmArquivo<T> where T : EntidadeBase
{
    protected int contadorId = 1;
    protected ContextoDados contexto;

    public RepositorioBaseEmArquivo(ContextoDados contexto)
    {
        this.contexto = contexto;
    }

    protected abstract List<T> ObterRegistros();

    public void Cadastrar(T novoRegistro)
    {
        novoRegistro.Id = contadorId++;

        ObterRegistros().Add(novoRegistro);

        contexto.Gravar();
    }

    public bool Editar(int id, T novaEntidade)
    {
        var registro = SelecionarPorId(id);

        if (registro == null)
            return false;

        registro.AtualizarRegistro(novaEntidade);

        contexto.Gravar();

        return true;
    }

    public virtual bool Excluir(int id)
    {
        var conseguiuExcluir = ObterRegistros().Remove(SelecionarPorId(id));

        if (!conseguiuExcluir)
            return false;

        contexto.Gravar();

        return true;
    }

    public List<T> SelecionarTodos()
    {
        return ObterRegistros();
    }

    public T SelecionarPorId(int id)
    {
        return ObterRegistros().Find(x => x.Id == id);
    }

    public bool Existe(int id)
    {
        return ObterRegistros().Any(x => x.Id == id);
    }
}