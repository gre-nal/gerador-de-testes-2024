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
        public Questao(string materia, string serie, string enunciado, string alternativaA, string alternativaB, string alternativaC, string alternativaD, int maxAlternativa, int minAlternativa, string alternativaCorreta)
        {
            this.materia = materia;
            this.serie = serie;
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
        public string serie {  get; set; }
        public string enunciado { get; set; }
        public string alternativaA { get; set; }
        public string alternativaB { get; set; }
        public string alternativaC { get; set; }
        public string alternativaD { get; set; }
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
            alternativaCorreta = atualizado.alternativaCorreta;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            VerificarNulo(ref erros, materia, "matéria");
            VerificarNulo(ref erros, enunciado, "enunciado");
            VerificarNulo(ref erros, alternativaA, "alternativa A");
            VerificarNulo(ref erros, alternativaB, "alternativa B");
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
