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

    /// <summary>
    /// Calcula la desviación estándar muestral de una muestra.
    /// </summary> <param name="muestra">Arreglo de valores numéricos.</param>
    /// <returns>Desviación estándar de la muestra.</returns>
    public double CalcularDesviacionEstandar(double[] muestra)
    {
        return Math.Sqrt(CalcularVarianza(muestra));
    }

    /// <summary> Calcula el estadístico T-Student para una muestra dada una media poblacional.
    /// </summary> <param name="muestra">Arreglo de valores numéricos.</param> <param name="mediaPoblacional">Media poblacional para comparar.</param>
    /// <returns>Valor del estadístico T-Student.</returns>
    public double CalcularTStudent(double[] muestra, double mediaPoblacional)
    {
        if (muestra == null || muestra.Length < 2)
            throw new ArgumentException("La muestra debe tener al menos 2 elementos.");

        double media = CalcularMedia(muestra);
        double desviacion = CalcularDesviacionEstandar(muestra);
        double n = muestra.Length;

        return (media - mediaPoblacional) / (desviacion / Math.Sqrt(n));
    }

    /// <summary> Calcula el estadístico T-Student para dos muestras independientes.
    /// </summary> <param name="muestra1">Arreglo de valores numéricos de la primera muestra.</param> 
    /// <param name="muestra2">Arreglo de valores numéricos de la segunda muestra.</param>
    /// <returns>Valor del estadístico T-Student.</returns>
    public double CalcularTStudentDosMuestras(double[] muestra1, double[] muestra2)
    {
        if (muestra1 == null || muestra1.Length < 2)
            throw new ArgumentException("La muestra 1 debe tener al menos 2 elementos.");
        if (muestra2 == null || muestra2.Length < 2)
            throw new ArgumentException("La muestra 2 debe tener al menos 2 elementos.");

        double media1 = CalcularMedia(muestra1);
        double media2 = CalcularMedia(muestra2);
        double var1 = CalcularVarianza(muestra1);
        double var2 = CalcularVarianza(muestra2);
        double errorEstandar = Math.Sqrt(var1 / muestra1.Length + var2 / muestra2.Length);

        return (media1 - media2) / errorEstandar;
    }
}