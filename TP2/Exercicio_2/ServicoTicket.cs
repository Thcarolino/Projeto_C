
using System;

public class ServicoTicket
{
    public void GerarResumo(int ticketTotal, double mediaHoras)
    {
        Console.WriteLine($"Tickets processados: {ticketTotal} | Permanência média: {mediaHoras:F2} h");
    }
}
