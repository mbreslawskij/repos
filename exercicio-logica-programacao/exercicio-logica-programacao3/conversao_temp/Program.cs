using System;

namespace conversao_temp
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0, fahrenheit = 0;
            string entradaC = " ", entradaF = " ";

            do
            {


                Console.WriteLine("Escolha um opção: \n" +
                    "1 - Para converter de Celsius para Fahrenheit. \n" +
                    "2 - Para converter de Fahrenheit para Celsius.");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (entradaC != string.Empty)
                        {
                            Console.WriteLine("Digite um temperatura em Celsius: ");
                            entradaC = Console.ReadLine();
                            celsius = Convert.ToDouble(entradaC);

                            fahrenheit = ((celsius / 5) * 9) + 32;

                            Console.WriteLine("A temperatura " + Math.Round(celsius, 2) + "°C em Fahrenheit é: " + Math.Round(fahrenheit, 2) + "°F");

                        }
                        break;

                    case "2":
                        if (entradaF != string.Empty)
                        {
                            Console.WriteLine("Digite um temperatura em Fahrenheit: ");
                            entradaF = Console.ReadLine();
                            fahrenheit = Convert.ToDouble(entradaF);

                            celsius = ((fahrenheit - 32) / 9) * 5;

                            Console.WriteLine("A temperatura " + Math.Round(fahrenheit, 2) + "°F em Celsius é: " + Math.Round(celsius, 2) + "°C");
                        }
                        break;

                    default:
                        Console.WriteLine("Ops! Você fez m**");
                        break;


                }

            } while (entradaC != string.Empty && entradaF != string.Empty);

        }
    }
}
