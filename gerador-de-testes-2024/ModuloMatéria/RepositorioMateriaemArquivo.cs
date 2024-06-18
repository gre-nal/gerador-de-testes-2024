using gerador_de_testes_2024.ModuloMateria;
using gerador_de_testes_2024.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_de_testes_2024.ModuloMatéria
{
    internal class RepositorioMateriaemArquivo : RepositorioBaseEmArquivo<Materia>
    {
        public RepositorioMateriaemArquivo() : base("Matérias.pdf")
        {
        }
    }
}
