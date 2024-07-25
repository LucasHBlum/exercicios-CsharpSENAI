﻿using System;

class Program
{
    static void Main()
    {
        double raio, altura, volume;
        const double PI = 3.14159;

        Console.WriteLine("Digite o raio da base da lata de óleo (em cm): ");
        raio = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura da lata de óleo (em cm): ");
        altura = double.Parse(Console.ReadLine());

        volume = PI * Math.Pow(raio, 2) * altura;

        Console.WriteLine($"O volume da lata de óleo é: {volume:F2} cm³");

    }
}
