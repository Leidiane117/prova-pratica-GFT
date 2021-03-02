using Prova_Pratica_GFT.source.Ex._1;
using Prova_Pratica_GFT.source.Ex._4;
using System;

namespace Prova_Pratica_GFT
{
    class Program
    {
        
        public static int intervalo ()
            {
            int n1, n2;

            Console.WriteLine("Digite o intervalo Inicial");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Digite o intervalo Final");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            int intervalo= n2 - n1 ;
            if (n1 > n2)
            {
                Console.WriteLine("INVÁLIDO:  intervalo final é menor que intervalo inicial");

            }
            if (intervalo <= 15) {
                for (int i = n1; i <= n2; i++)
                {

                    Console.WriteLine("Cubo de " + i + " = " + Math.Pow(i, 3).ToString());

                }
            }
         
            else
            {
              
                Console.WriteLine("INVÁLIDO:   Intervalo maior que 15 \n ") ;
            }

            return intervalo;
        }

        public static int divisor()
        {
            int n;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());

            if (n % 3 == 0 && n % 6 == 0 && n % 7 == 0)
            {
                Console.WriteLine(n+ " É divisível por 3,6,7");
            }
            else if (n % 3 == 0 && n % 6 == 0)
            {
                Console.WriteLine(n + "É divisível por 3,6");
            }
                       
            else if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine(n + "É divisível por 3,7");
            }
            else if (n % 6 == 0 && n % 0 == 7)
            {

                Console.WriteLine(n + "É divisível por 6,7");

            }
            else if (n % 3 == 0)
            {
                Console.WriteLine(n + " É divisível por 3");

            }
            else if (n % 6 == 0)
            {
                Console.WriteLine(n + " É divisível por 6");

            }
            else if (n % 7 == 0)
            {
                Console.WriteLine(n + " É divisível por 7");

            }
          
            else
            {
                Console.WriteLine("Não é divisível nem por 3 nem 6 nem 7");

            }
            int r;

            Console.WriteLine("tecle 1 para continuar ou  qualquer outro número  e enter  para sair");
            r = int.Parse(Console.ReadLine());

            if (r == 1)

            {
                Console.Clear();
                Program.divisor();
            }
            return n;

        }
     
       public static double total()
        {
            double valor;
            Console.WriteLine("Digite um valor :");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("");

           
            var icms = new ICMS();
           double totICms=  icms.calculaImposto(valor);

            var ipi = new IPI();
           double totlIpi=   ipi.calculaImposto(valor);

            var imposto = new COFINS();
           double totlCofins=     imposto.calculaImposto(valor);

            double ttotalImpostos = totlCofins + totICms + totlIpi + valor;
          
            Console.WriteLine("Valor Final: " +ttotalImpostos );

            return valor;
        }
           
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            Console.WriteLine("GFT \n" );

            Produto produto = new Produto("Banana",0.99,2);  //ok
            Produto produto1 = new Produto("Energético", 5.49, 3);
            Produto produto2 = new Produto("Arroz",20.00, 1);
            Produto produto3 = new Produto("Chocolate", 4.50, 1);
            Produto produto4 = new Produto("Leite",3.73, 3);
            Produto produto5 = new Produto("Abacaxi", 2.40, 2);
                
            Caixa caixa = new Caixa(); //ok
             Console.WriteLine(produto.Nome + " "  +   caixa.calculaValorFinal(produto.Tipo, 3, produto.Valor)+   "   REAIS ");
            Console.WriteLine(produto1.Nome + " "   +  caixa.calculaValorFinal(produto1.Tipo, 7, produto1.Valor) + " REAIS ");
            Console.WriteLine(produto2.Nome + " "    +  caixa.calculaValorFinal(produto2.Tipo, 1, produto2.Valor) + "  REAIS ");
            Console.WriteLine(produto3.Nome +  " "     + caixa.calculaValorFinal(produto3.Tipo, 20, produto3.Valor) + "  REAIS ");
            Console.WriteLine(produto4.Nome +  " "     + caixa.calculaValorFinal(produto4.Tipo, 3, produto4.Valor) + "  REAIS ");
            Console.WriteLine(produto5.Nome +  " "    + caixa.calculaValorFinal(produto5.Tipo, 4, produto5.Valor) + "  REAIS ");

            Console.WriteLine("Fim");
            Console.Clear();

            Console.WriteLine(" ");
            Program.intervalo(); //ok
            Console.WriteLine(" ");
            Program.divisor(); // ok
            Console.WriteLine(" ");
            Program.total(); //ok
         



            Console.ReadLine();
     }
    }
}
