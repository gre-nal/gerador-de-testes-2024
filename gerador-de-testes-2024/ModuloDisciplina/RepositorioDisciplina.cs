using gerador_de_testes2024.Compartilhado;

namespace gerador_de_testes2024.ModuloDisciplina;

public class RepositorioDisciplina : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
{
    public RepositorioDisciplina(ContextoDados contexto) : base(contexto)
    {
        if (contexto.Disciplinas.Any())
            contadorId = contexto.Disciplinas.Max(i => i.Id) + 1;
        else
            AdicionarDisciplinasBase();
    }

    protected override List<Disciplina> ObterRegistros()
    {
        return contexto.Disciplinas;
    }

    private void AdicionarDisciplinasBase()
    {
        var disciplina1 = new Disciplina("Matemática");
        disciplina1.Id = 1;
        var disciplina2 = new Disciplina("Português");
        disciplina2.Id = 2;
        var disciplina3 = new Disciplina("Geografia");
        disciplina3.Id = 3;
        var disciplina4 = new Disciplina("Biologia");
        disciplina4.Id = 4;
        var disciplina5 = new Disciplina("Química");
        disciplina5.Id = 5;
        var disciplina6 = new Disciplina("Física");
        disciplina6.Id = 6;

        contexto.Disciplinas.Add(disciplina1);
        contexto.Disciplinas.Add(disciplina2);
        contexto.Disciplinas.Add(disciplina3);
        contexto.Disciplinas.Add(disciplina4);
        contexto.Disciplinas.Add(disciplina5);
        contexto.Disciplinas.Add(disciplina6);
    }
}