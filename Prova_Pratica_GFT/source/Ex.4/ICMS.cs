using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._4
{
   public  class ICMS : Iimposto
    {
        void Iimposto.calculaImposto(double valor)
        {
           
           double valorI = valor * 0.30;

            Console.WriteLine("Valor incidente do Imposto ICMS"+""+ valorI);


        }
        


        }


    }

