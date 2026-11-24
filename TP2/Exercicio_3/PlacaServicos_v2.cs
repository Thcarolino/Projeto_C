public class PlacaServicos_v2
{
    // Método para normalizar a placa
    public string NormalizarPlaca(string placa)
    {
        return placa.Trim().ToUpper();
    }

    // Método para Validar a placa
    public bool PlacaValida(string placa)
    {
        // Verifica se a placa tem 7 caracteres
        if (placa.Length != 7)
        {
            return false;
        }

        // Verifica cada posição da placa:
        return char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]) &&
               char.IsDigit(placa[3]) && char.IsLetter(placa[4]) && char.IsDigit(placa[5]) &&
               char.IsDigit(placa[6]);
    }
}