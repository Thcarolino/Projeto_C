using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da PlacaServicos_v2
        PlacaServicos_v2 placaServicos = new PlacaServicos_v2();

        // Placas para teste
        string placa1 = "SRT1D23";
        string placa2 = "Asf1823";
        string placa3 = "   AB11C34";
        string placa4 = "ikj2C33    ";

        TestarPlaca(placaServicos, placa1);
        TestarPlaca(placaServicos, placa2);
        TestarPlaca(placaServicos, placa3);
        TestarPlaca(placaServicos, placa4);

        static void TestarPlaca(PlacaServicos_v2 placaServicos, string placa)
        {
            // Normaliza e valida a placa
            string placaNormalizada = placaServicos.NormalizarPlaca(placa);
            bool valida = placaServicos.PlacaValida(placaNormalizada);

            // Exibe o resultado:
            Console.WriteLine($"Placa: {placa} | Normalizada: {placaNormalizada} | Válida: {valida}");
        }
    }
}
