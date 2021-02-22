using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._1
{
    public class Caixa
    {
        public double calculaValorFinal(int produto, int quantidade, double valor)
        {
            double tot=0;
            double valorTot;
            if (produto == 1)
            {

                valorTot = valor - (valor * 0.10);
                tot = valorTot * quantidade;
                Console.WriteLine("Valor com desconto:" + "" +tot);
            }
            else if (produto == 2)
            {
                
                valorTot = valor - (valor * 0.20);
                tot = valorTot * quantidade;
                Console.WriteLine("Valor com desconto:" + " "+ tot);

            }
            else if (produto == 3 && quantidade > 5)
            {
                
                valorTot = valor - (valor * 0.10);
                tot = valorTot * quantidade;
                Console.WriteLine("Valor com desconto:" + " " + tot);


            }

            return tot;
        }
    }
}
