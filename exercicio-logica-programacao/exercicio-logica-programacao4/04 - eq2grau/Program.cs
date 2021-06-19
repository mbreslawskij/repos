using System;

namespace _04___eq2grau
{
    class Program
    {
        static void Main(string[] args);
        double a = 0, b = 0, c = 0, delta = 0, x1 = 0, x2 = 0;
        string entradaA = " ", entradaB = " ", entradaC = " ";
            // a, b, c são constantes da equação do 2ª grau;

            do
            {


                {

                Console.WriteLine("Digite um valor para a: ");
                entradaA = Console.ReadLine();
                a = Convert.ToDouble(entradaA);
                Console.WriteLine("Digite um valor para b: ");
                entradaB = Console.ReadLine();
                b = Convert.ToDouble(entradaB);
                Console.WriteLine("Digite um valor para c: ");
                entradaC = Console.ReadLine();
                c = Convert.ToDouble(entradaC);

                delta = b* b - 4 * a* c;
        Console.WriteLine(delta);

                if (delta< 0)
                    {
                        Console.WriteLine("Não existe raiz de valor negativo dentro do conjunto dos reais.");
                        break;
                    }


    // x = (-b +- raiz de delta) / 2 * a

    x1 = (-b - Math.Round(Math.Sqrt(delta), 2)) / 2;
                x2 = (-b + Math.Round(Math.Sqrt(delta), 2)) / 2;

                Console.WriteLine("O valor de x' é: " + Math.Round(x1, 2) + ".\n" +
                    "O valor de x'' é: " + Math.Round(x2, 2) + ".");
                }
            } while (a != 0 && b != 0 || c != 0) ;
    }
}

//using System;

//namespace Exe04
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double valor1, valor2, valor3, aux;




//            Console.WriteLine("###############################################");
//            Console.WriteLine("#                Bhaskara                     #");
//            Console.WriteLine("###############################################");


//            Console.WriteLine("Informe 3 valores para realizar o cálculo: ");
//            valor1 = Convert.ToDouble(Console.ReadLine());
//            valor2 = Convert.ToDouble(Console.ReadLine());
//            valor3 = Convert.ToDouble(Console.ReadLine());

//            double delta1 = Math.Sqrt(valor2 * valor2);
//            double delta2 = Math.Sqrt(4 * valor1 * valor3);

//            double delta = (delta1 - delta2);

//            double num1 = (-valor2 + (delta)) / (2 * valor1);
//            double num2 = (-valor2 - (delta)) / (2 * valor1);


//            Console.WriteLine("resultado 1 " + num1 + " e resultado 2 " + num2);

//        }




//    }
//}