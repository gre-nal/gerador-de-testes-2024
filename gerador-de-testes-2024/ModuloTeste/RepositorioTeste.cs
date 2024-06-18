using gerador_de_testes2024.Compartilhado;
using gerador_de_testes2024.ModuloDisciplina;
using gerador_de_testes2024.ModuloQuestao;

namespace gerador_de_testes2024.ModuloTeste;

public class RepositorioTeste : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
{
    public RepositorioTeste(ContextoDados contexto) : base(contexto)
    {
        if (contexto.Testes.Any())
            contadorId = contexto.Questoes.Max(i => i.Id) + 1;
    }

    public void atualizarDependenciaDisciplina(Disciplina disciplinaSelecionada, Disciplina disciplinaEditada)
    {
        var teste = new List<Teste>();

        foreach (var t in contexto.Testes)
            if (t.Disciplina.Id == disciplinaSelecionada.Id)
                t.Disciplina = disciplinaEditada;
    }

    public override bool Excluir(int id)
    {
        var teste = SelecionarPorId(id);

        var questoes = new List<Questao>();
        foreach (var q in contexto.Questoes)
            if (q.Testes.Find(t => t.Id == teste.Id) != null)
                questoes.Add(q);
        var testes = new List<Teste>();
        foreach (var q in questoes)
        {
            foreach (var t in q.Testes)
                if (t.Id != teste.Id)
                    testes.Add(t);
            q.Testes.Clear();
            q.Testes = testes;
        }


        testes = new List<Teste>();
        var disciplina = contexto.Disciplinas.Find(d => d.Id == teste.Disciplina.Id);
        foreach (var t in disciplina.Testes)
            if (t.Id != teste.Id)
                testes.Add(t);
        disciplina.Testes.Clear();
        disciplina.Testes = testes;

        return base.Excluir(id);
    }

    protected override List<Teste> ObterRegistros()
    {
        return contexto.Testes;
    }
}