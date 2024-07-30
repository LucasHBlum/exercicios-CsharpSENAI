using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número
        Console.Write("Digite um número: ");

        // Lê a entrada do usuário e converte para um número inteiro
        int numero;
        bool sucesso = Int32.TryParse(Console.ReadLine(), out numero);

        // Verifica se a conversão foi bem-sucedida
        if (sucesso)
        {
            // Verifica se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é um número par.");
            }
            else
            {
                Console.WriteLine($"{numero} é um número ímpar.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }
}