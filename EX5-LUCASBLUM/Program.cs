using System;

class Program
{
    static void Main()
    {
        double numero1, numero2, soma, subtracao, multiplicacao, divisao;

        Console.WriteLine("Digite o primeiro número: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        numero2 = double.Parse(Console.ReadLine());

        soma = numero1 + numero2;
        subtracao = numero1 - numero2;
        multiplicacao = numero1 * numero2;
        divisao = numero1 / numero2;

        Console.WriteLine($"A soma dos números é: {soma:F2}");
        Console.WriteLine($"A subtração dos números é: {subtracao:F2}");
        Console.WriteLine($"A multiplicação dos números é: {multiplicacao:F2}");
        Console.WriteLine($"A divisão dos números é: {divisao:F2}");
    }
}