using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._4
{
    public class COFINS : IImposto
    {

        public double calculaImposto(double valor)
        {

            double valorI=0;
            if (valor > 12000.00)
            {
                valorI = valor * 0.08;
                Console.WriteLine("------ COFINS ------ "  + " " + valorI);
            }

            else if (valor <= 12000.00)
            {

                Console.WriteLine("----COFINS-----0");
            }
           return valorI;
        }
    }
}
