using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o salário base do vendedor: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o total de vendas do vendedor: ");
        double totalVendas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a porcentagem de comissão (em %): ");
        double percentualComissao = double.Parse(Console.ReadLine());

        double comissao = (percentualComissao / 100) * totalVendas;

        double salarioTotal = salarioBase + comissao;

        Console.WriteLine($"Salário base: {salarioBase:C}");
        Console.WriteLine($"Comissão: {comissao:C}");
        Console.WriteLine($"Salário total: {salarioTotal:C}");

    }
}