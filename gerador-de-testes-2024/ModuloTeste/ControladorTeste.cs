﻿using gerador_de_testes_2024.ModuloQuestao;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using gerador_de_testes_2024.Compartilhado;

namespace gerador_de_testes_2024.ModuloTeste
{
    internal class ControladorTeste : ControladorBase
    {
        private List<Teste> testes = new List<Teste>();
        private int ultimoId = 0;
        public override string TipoCadastro { get; }
        public override string ToolTipAdicionar { get; }
        public override string ToolTipEditar { get; }
        public override string ToolTipExcluir { get; }

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}