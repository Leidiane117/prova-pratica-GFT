using Prova_Pratica_GFT.source.Ex._1;
using Prova_Pratica_GFT.source.Ex._2;
using Prova_Pratica_GFT.source.Ex._4;
using System;

namespace Prova_Pratica_GFT
{
    class Program
    {

           
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("GFT" );


            Produto produto = new Produto("Banana",0.99,2);  //ok
            Produto produto1 = new Produto("Energético", 5.49, 3);
            Produto produto2 = new Produto("Arroz", 20.00, 1);
            Produto produto3 = new Produto("Chocolate", 4.50, 1);
            Produto produto4 = new Produto("Leite",3.73, 3);
            Produto produto5 = new Produto("Abacaxi", 2.40, 2);


            Caixa caixa = new Caixa(); //ok
             Console.WriteLine(produto.Nome + caixa.calculaValorFinal(produto.Tipo, 3, 0.99));
            Console.WriteLine(produto1.Nome + caixa.calculaValorFinal(produto1.Tipo, 7, 5.49));
            Console.WriteLine(produto2.Nome +  caixa.calculaValorFinal(produto2.Tipo, 1, 20.00));
            Console.WriteLine(produto3.Nome + caixa.calculaValorFinal(produto3.Tipo, 20, 4.50));
            Console.WriteLine(produto4.Nome + caixa.calculaValorFinal(produto4.Tipo, 3, 3.73));
            Console.WriteLine(produto4.Nome + caixa.calculaValorFinal(produto5.Tipo, 4, 2.40));


            Ex2_e_Ex3 intervalo = new Ex2_e_Ex3();
            intervalo.CalculoIntervalo(1, 15); // não consegui realizar este, mas tentei, obrigada

            intervalo.Divisor(9); // ok

          
            Console.ReadLine();
     }
    }
}
