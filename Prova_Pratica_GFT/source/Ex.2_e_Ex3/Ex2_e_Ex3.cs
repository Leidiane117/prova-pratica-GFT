using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Pratica_GFT.source.Ex._2
{
    public class Ex2_e_Ex3
    {
        public void CalculoIntervalo(int n1, int n2)
        {

            int potencia = n1 ^ 3;
            int potencia2 = n2 ^ 3;


            for (int i = n1; i <= n2; i++)
            {

                Console.WriteLine("Cubo de :" + potencia);
            }
            for (int i = n1; i <= n2; i++)


                if (n2 > 15)
                {
                    break;

                }
                else
                {
                    Console.WriteLine(potencia);
                    Console.WriteLine(potencia2);

                }

        }
        public void Divisor(int numero)
        {
            int div3 = 3;
            int div6 = 6;
            int div7 = 7;


            {
                if (numero % 3 == 0)
                {

                    Console.WriteLine("O número é divisível por" + " " +div3);
                }
                else if (numero % 6 == 0)
                {

                    Console.WriteLine("O número é divisível por" + "" + div6);

                }
                else if (numero % 7 == 0)

                {

                    Console.WriteLine("O número é divisível por" + "" +div7);
                }
               

            }

        }
    }
}
    

