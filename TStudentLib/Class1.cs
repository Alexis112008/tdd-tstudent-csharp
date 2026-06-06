namespace TStudentLib;

public class TStudentCalculator
{
    // MÉTODO 1: Calcular Media
    public double CalcularMedia(double[] muestra)
    {
        if (muestra == null || muestra.Length == 0)
            throw new ArgumentException("La muestra no puede ser nula o vacía.");

        double suma = 0;
        foreach (double valor in muestra)
            suma += valor;

        return suma / muestra.Length;
    }
}