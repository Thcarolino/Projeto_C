using System;
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe PlacaServiços
        PlacaServiços placaServicos = new PlacaServiços();

        // Teste do método NormalizadorPlaca
        string placa1 = "ATX2206";
        string placa2 = "  XCG5537";
        string placa3 = "ctg9922";

        string placaNormalizada1 = placaServicos.NormalizadorPlaca(placa1);
        string placaNormalizada2 = placaServicos.NormalizadorPlaca(placa2);
        string placaNormalizada3 = placaServicos.NormalizadorPlaca(placa3);

        // Exibindo os resultados
        Console.WriteLine($"Placa Normalizada: {placaNormalizada1}");
        Console.WriteLine($"Placa Normalizada: {placaNormalizada2}");
        Console.WriteLine($"Placa Normalizada: {placaNormalizada3}");
    }
}
