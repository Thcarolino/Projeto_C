
using System;

namespace Estacionamento
{
    public class Veiculo
    {
        public string Placa;
        public DateTime HorarioEntrada;
        public string Tipo;

        private decimal valorPago;

        public decimal ValorPago
        {
            get
            {
                return valorPago;
            }

            set
            {
                if (value >= 0)
                {
                    valorPago = value;
                }
            }
        }

        // Primeiro construtor
        public Veiculo(string placa, DateTime horarioEntrada, string tipo)
        {
            Placa = placa;
            HorarioEntrada = horarioEntrada;
            Tipo = tipo;
        }

        // Segundo construtor
        public Veiculo(string placa, string tipo)
        {
            Placa = placa;
            HorarioEntrada = DateTime.Now;
            Tipo = tipo;
        }
    }
}
