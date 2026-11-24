public class PlacaServiços
{
public string NormalizadorPlaca(string placa)
    {
        return placa.ToUpper().Trim();
    }
}