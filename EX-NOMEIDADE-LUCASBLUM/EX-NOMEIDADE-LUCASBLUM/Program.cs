using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Digite seu nome completo: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Nome: {nome} \nIdade: {idade}");
    }
}