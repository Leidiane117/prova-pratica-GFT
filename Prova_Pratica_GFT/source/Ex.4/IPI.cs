using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._4
{
   public  class IPI:IImposto
    {

       public  double calculaImposto(double valor)
        {

            double valorI=0 ;

            if (valor < 25000.00)
            {
                valorI = valor * 0.05;
                Console.WriteLine("-------IPI-------" + " " + valorI);
            }

            else if (valor>=2500)
            {
                valorI = valor * 0.10;
                Console.WriteLine("--------IPI------- " + " " + valorI);
            }
            return valorI;
        }
        }

    }
