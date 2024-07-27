using System;
using System.Data;

class Program
{
    static void Main()

    {

        Console.WriteLine("Qual das operações você deseja calcular?: \n1 = CELSIUS=>FAHRENHEIT \n2 = FAHRENHEIT=>CELSIUS");
        int opcao = int.Parse(Console.ReadLine());

        Console.Clear();

        if (opcao == 1) {
            Console.WriteLine("Digite o valor de temperatura desejado (Celsius): ");
            double valor = double.Parse(Console.ReadLine());

            double fahrenheit = valor * 1.8 + 32;

            Console.WriteLine($"O valor de temperatura da conversão de Celsius para Fahrenheit é: {fahrenheit}");
        } else
        {
            Console.WriteLine("Digite o valor de temperatura desejado (Fahrenheit): ");
            double valor2 = double.Parse(Console.ReadLine());

            double celsius = valor2 / 1.8 - 32;

            Console.WriteLine($"O valor de temperatura da conversão de Fahrenheit para Celsius é: {celsius}");
        }
    }
}