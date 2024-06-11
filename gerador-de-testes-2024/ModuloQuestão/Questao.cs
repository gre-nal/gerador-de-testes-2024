using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerador_de_testes_2024.WinApp.Compartilhado;

namespace gerador_de_testes_2024.ModuloQuestão
{
    public class Questao : EntidadeBase
    {
        public Questao(string materia, string enunciado, bool alternativaA, bool alternativaB, bool alternativaC, bool alternativaD, int maxAlternativa, int minAlternativa, string alternativaCorreta)
        {
            this.materia = materia;
            this.enunciado = enunciado;
            this.alternativaA = alternativaA;
            this.alternativaB = alternativaB;
            this.alternativaC = alternativaC;
            this.alternativaD = alternativaD;
            this.maxAlternativa = maxAlternativa;
            this.minAlternativa = minAlternativa;
            this.alternativaCorreta = alternativaCorreta;
        }

        public string materia { get; set; }
        public string enunciado { get; set; }
        public bool alternativaA { get; set; }
        public bool alternativaB { get; set; }
        public bool alternativaC { get; set; }
        public bool alternativaD { get; set; }
        public int maxAlternativa { get; set; }
        public int minAlternativa { get; set; }
        public string alternativaCorreta {  get; set; }



        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            var atualizado = (Questao)novoRegistro;

            materia = atualizado.materia;
            enunciado = atualizado.enunciado;
            alternativaA = atualizado.alternativaA;
            alternativaB = atualizado.alternativaB;
            alternativaC = atualizado.alternativaC;
            alternativaD = atualizado.alternativaD;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            VerificarNulo(ref erros, materia, "matéria");
            VerificarNulo(ref erros, enunciado, "enunciado");
            VerificarNulo(ref erros, alternativaA, "alternativa A");
            VerificarNulo(ref erros, alternativaB, "alternativa B");
            VerificarNulo(ref erros, alternativaC, "alternativa C");
            VerificarNulo(ref erros, alternativaD, "alternativa D");
            VerificarNulo(ref erros, alternativaCorreta, "alternativaCorreta");
            VerificarNulo(ref erros, maxAlternativa, "máximo de alternativas");
            VerificarNulo(ref erros, minAlternativa, "mínimo de alternativas");

            return erros;
        }

        public override string ToString()
        {
            return $"Id: {Id}, " +
                   $"matéria: {materia.ToTitleCase()}, " +
                   $"enunciado: {enunciado}" +
                   $"alternativa correta: {alternativaCorreta}";
        }

        private void VerificarNulo(ref List<string> erros, object valor, string nomeCampo)
        {
            if (valor == null)
            {
                erros.Add($"O campo '{nomeCampo}' é obrigatório.");
            }
        }
    }
}
