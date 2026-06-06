namespace TStudentLib;

public class TStudentCalculator
{
    /// <summary>
    /// Calcula la media aritmética de una muestra.
    /// </summary>
    /// <param name="muestra">Arreglo de valores numéricos.</param>
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
}