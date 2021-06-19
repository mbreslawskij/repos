using System;

namespace _05___somardigitos
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int digito;
            int soma = 0;

            Console.Write("Informe um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                digito = numero % 10; // acha o ultimo numero
                soma = soma + digito;
                numero = numero / 10; //acha os numeros restantes.

            }

            Console.Write("Soma= " + soma);
            Console.ReadKey();
        }
    }
}
