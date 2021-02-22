using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._1
{
   public   class Produto
    {
        private string nome;
        private double valor;
        private int tipo;

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        public Produto(string nome, double valor, int tipo)
        {
            Nome = nome;
            Valor = valor;
            Tipo = tipo;
        }
    }
}
