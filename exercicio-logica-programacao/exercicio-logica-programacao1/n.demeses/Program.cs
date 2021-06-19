using System;

namespace n.demeses
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDeDias = 0, diasDoMes = 30, n = 0;
            Console.WriteLine("Digite o numero de meses que deseja calcular: ");
            string numerosDeMeses = Console.ReadLine();
            n = Convert.ToInt32(numerosDeMeses);
            totalDeDias = diasDoMes * n;

            Console.WriteLine("O numero de dias é  " + n + " meses é: " + totalDeDias);
        }
    }
}
