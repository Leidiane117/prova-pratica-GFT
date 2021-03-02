using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._4
{
   public  class ICMS : IImposto
    {
       public  double calculaImposto(double valor)
        {

            double valorl = valor * 0.30;
            Console.WriteLine("------ ICMS------"+" "+ valorl);


            return valorl;

        }
     


        }


    }
