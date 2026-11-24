
using System;
using Estacionamento;

class Program
{
    static void Main(string[] args)
    {
        // Criando um veículo
        Veiculo veiculo = new Veiculo("XTG1D23", "Caminhonete");

        // Definindo o valor pago
        veiculo.ValorPago = 55.20m;

        // Criando o recibo de saída
        ReciboSaida recibo = new ReciboSaida(
            veiculo.Placa,
            veiculo.ValorPago
        );

        // Exibindo os dados do recibo
        Console.WriteLine("===== RECIBO DE SAÍDA =====");
        Console.WriteLine($"Tipo: {veiculo.Tipo}");
        Console.WriteLine($"Placa: {recibo.Placa}");
        Console.WriteLine($"Valor final pago: R$ {recibo.ValorFinalPago:F2}");

        // Teste de imutabilidade:
        veiculo.ValorPago = 150.00m;

        Console.WriteLine("\n===== TESTE DE IMUTABILIDADE =====");
        Console.WriteLine($"Valor atual do veículo: R$ {veiculo.ValorPago:F2}");
        Console.WriteLine($"Valor registrado no recibo: R$ {recibo.ValorFinalPago:F2}");
    }
}

