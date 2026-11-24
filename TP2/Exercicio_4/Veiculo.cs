using System;

namespace Estacionamento
{
    public class Veiculo
    {
        // Valores das propriedades
        public string Placa;
        public DateTime HorarioEntrada;
        public string Tipo;

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
