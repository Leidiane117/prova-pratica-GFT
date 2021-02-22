using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._4
{
    class COFINS : Iimposto
    {

        void Iimposto.calculaImposto(double valor)
        {

            double valorI;
            if (valor > 12000.00)
            {
                valorI = valor * 0.08;
                Console.WriteLine("Valor incidente do Imposto ICMS" + "" + valorI);
            }

            else if (valor <= 12000.00)
            {

                Console.WriteLine("Não tem incidência  ICMS" + "");
            }

        }
    }
}
