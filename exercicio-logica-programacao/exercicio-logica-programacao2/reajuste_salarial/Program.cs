using System;

namespace reajuste_salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0, percentual = 0, salarioReajustado = 0;
            string nome;

            Console.WriteLine("Digite o nome do colaborador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do salario: ");
            string entradaSalario = Console.ReadLine();
            salario = Convert.ToDouble(entradaSalario);
            Console.WriteLine("Digite o percentual do aumento:");
            string entradaPercentual = Console.ReadLine();
            percentual = Convert.ToDouble(entradaPercentual);

            salarioReajustado = salario + (salario * (percentual / 100));
            Console.WriteLine("Valor do salario reajustado: " + Math.Round(salarioReajustado, 2));


        }
    }
}
