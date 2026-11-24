
using System;
using Estacionamento;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Veiculo
        Veiculo veiculo = new Veiculo("XLJ3R54", "Carro");

        // Atribuindo um valor válido
        veiculo.ValorPago = 142.50m;

        Console.WriteLine($"Placa: {veiculo.Placa}");
        Console.WriteLine($"Tipo: {veiculo.Tipo}");
        Console.WriteLine($"Valor original: R$ {veiculo.ValorPago:F2}");

        // Tentando atribuir um valor negativo
        Console.WriteLine("\nTentando atribuir um valor negativo...");

        veiculo.ValorPago = -100.00m;

        // Verificando se o valor original foi preservado
        Console.WriteLine($"Valor após a tentativa: R$ {veiculo.ValorPago:F2}");

        // Confirmando o resultado
        if (veiculo.ValorPago == 142.50m)
        {
            Console.WriteLine("Teste aprovado! O valor original foi preservado.");
        }
        else
        {
            Console.WriteLine("Teste reprovado!");
        }
    }
}

