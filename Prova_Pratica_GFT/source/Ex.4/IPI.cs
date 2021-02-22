using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._4
{
    class IPI:Iimposto
    {

        void Iimposto.calculaImposto(double valor)
        {

            double valorI ;

            if (valor < 2500.00)
            {
                valorI = valor * 0.05;
                Console.WriteLine("Valor incidente do Imposto ICMS" + "" + valorI);
            }

            else if (valor>=2500)
            {
                valorI = valor * 0.10;
                Console.WriteLine("Valor incidente do Imposto ICMS" + "" + valorI);
            }

        }
        }

    }

