using System;
using Estacionamento;

class Program
{
    static void Main(string[] args)
    {
        // Utilização do priemeiro construtor:
        Veiculo veiculo1 = new Veiculo("AXG2D34", new DateTime(2026, 11, 15, 09, 25, 0), "Carro");

        // Utilização do segundo construtor:
        Veiculo veiculo2 = new Veiculo("BGH5F67", "Moto");
        Veiculo veiculo3 = new Veiculo("CDX8F90", "Caminhão");

        // Exibindo informações dos veículos:
        ExibirVeiculo(veiculo1);
        ExibirVeiculo(veiculo2);
        ExibirVeiculo(veiculo3);

    }

    static void ExibirVeiculo(Veiculo veiculo)
    {
        Console.WriteLine("Placa: " + veiculo.Placa);
        Console.WriteLine("Horário de Entrada: " + veiculo.HorarioEntrada);
        Console.WriteLine("Tipo: " + veiculo.Tipo);
        Console.WriteLine("'-----------------------------");
    }
}
