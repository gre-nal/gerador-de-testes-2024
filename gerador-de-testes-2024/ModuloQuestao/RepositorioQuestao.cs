using gerador_de_testes2024.Compartilhado;

namespace gerador_de_testes2024.ModuloQuestao;

internal class RepositorioQuestao : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
{
    public RepositorioQuestao(ContextoDados contexto) : base(contexto)
    {
        if (contexto.Questoes.Any())
            contadorId = contexto.Questoes.Max(i => i.Id) + 1;
    }

    protected override List<Questao> ObterRegistros()
    {
        return contexto.Questoes;
    }
}