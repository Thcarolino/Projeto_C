using System;
namespace Estacionamento
{
    public class Veiculo
    {
        // Valores Públicos:
        public string Placa;
        public DateTime HorarioEntrada;
        public string Tipo;

        // Valores Privados:
        private decimal valorPago;

        public decimal ValorPago
        {
            get{
                return valorPago;
            }
            set{
                if(value >= 0)
                {
                    valorPago = value;
                }
        }
        }
        // Construtor que recebe os 3(três) parâmetros:
        public Veiculo(string placa, DateTime horarioEntrada, string tipo)
        {
            Placa = placa;
            HorarioEntrada = horarioEntrada;
            Tipo = tipo;
        }

        // Construtor que recebe apenas 2(dois) parâmetros:
        public Veiculo(string placa, string tipo)
        {
            Placa = placa;
            HorarioEntrada = DateTime.Now;
            Tipo = tipo;
        }
    }
}