using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe ServicoTicket
        ServicoTicket servicoTicket = new ServicoTicket();

        // Conjunto de Dados 1
        int ticket1= 10;
        double mediaHoras_1 = 2.3;
        // Conjunto de Dados 2
        int ticket2 = 5;
        double mediaHoras_2 = 3.59;

        // Gerando Resumos:
        servicoTicket.GerarResumo(ticket1, mediaHoras_1);
        servicoTicket.GerarResumo(ticket2, mediaHoras_2);
    }
}
