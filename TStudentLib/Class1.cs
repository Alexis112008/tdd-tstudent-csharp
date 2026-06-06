namespace TStudentLib;

public class TStudentCalculator
{
    /// <summary> Calcula la media de una muestra de datos.
    /// </summary> <param name="muestra">Arreglo de valores numéricos.</param> 
    /// <returns>Media aritmética de la muestra.</returns>
    public double CalcularMedia(double[] muestra)
    {
        if (muestra == null || muestra.Length == 0)
            throw new ArgumentException("La muestra no puede ser nula o vacía.");

        double suma = 0;
        foreach (double valor in muestra)
            suma += valor;

        return suma / muestra.Length;
    }

    /// <summary> Calcula la varianza de una muestra de datos.
    /// </summary> <param name="muestra">Arreglo de valores numéricos.</param> 
    /// <returns>Varianza de la muestra.</returns>
    public double CalcularVarianza(double[] muestra)
    {
        if (muestra == null || muestra.Length < 2)
            throw new ArgumentException("La muestra debe tener al menos 2 elementos.");

        double media = CalcularMedia(muestra);
        double sumaCuadrados = 0;

        foreach (double valor in muestra)
            sumaCuadrados += Math.Pow(valor - media, 2);

        return sumaCuadrados / (muestra.Length - 1);
    }
}