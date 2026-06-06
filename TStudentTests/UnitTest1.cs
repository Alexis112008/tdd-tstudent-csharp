namespace TStudentTests;

public class TStudentCalculatorTests
{
    private readonly TStudentLib.TStudentCalculator _calc;

    public TStudentCalculatorTests()
    {
        _calc = new TStudentLib.TStudentCalculator();
    }
    //Prueba 1: Media
    [Fact]
    public void CalcularMedia_ConDatosValidos_RetornaMediaCorrecta()
    {
        double[] muestra = { 2, 4, 6, 8, 10 };
        double resultadoEsperado = 6.0;
        double resultado = _calc.CalcularMedia(muestra);
        Assert.Equal(resultadoEsperado, resultado);
    }

    //Prueba 2:Varianza
    [Fact]
    public void CalcularVarianza_ConDatosValidos_RetornaVarianzaCorrecta()
    {
        double[] muestra = { 2, 4, 6, 8, 10 };
        double resultadoEsperado = 10.0;
        double resultado = _calc.CalcularVarianza(muestra);
        Assert.Equal(resultadoEsperado, resultado);
    }

    // PRUEBA 3: Desviación Estándar
    [Fact]
    public void CalcularDesviacionEstandar_ConDatosValidos_RetornaDesviacionCorrecta()
    {
        double[] muestra = { 2, 4, 6, 8, 10 };
        double resultadoEsperado = Math.Sqrt(10.0);

        double resultado = _calc.CalcularDesviacionEstandar(muestra);

        Assert.Equal(resultadoEsperado, resultado, 10);
    }

    // PRUEBA 4: Estadístico T-Student
    [Fact]
    public void CalcularTStudent_ConDatosValidos_RetornaTStudentCorrecto()
    {
        double[] muestra = { 2, 4, 6, 8, 10 };
        double mediaPoblacional = 5.0;
        // t = (media - mu) / (desviacion / sqrt(n))
        // t = (6 - 5) / (sqrt(10) / sqrt(5)) = 1 / (3.162/2.236) = 0.7071
        double resultadoEsperado = 0.7071;

        double resultado = _calc.CalcularTStudent(muestra, mediaPoblacional);

        Assert.Equal(resultadoEsperado, resultado, 4);
    }

    // PRUEBA 5: Dos muestras independientes
    [Fact]
    public void CalcularTStudentDosMuestras_ConDatosValidos_RetornaTStudentCorrecto()
    {
        double[] muestra1 = { 2, 4, 6, 8, 10 };
        double[] muestra2 = { 1, 3, 5, 7, 9 };
        // t = (media1 - media2) / sqrt(var1/n1 + var2/n2)
        // t = (6 - 5) / sqrt(10/5 + 10/5) = 1 / sqrt(4) = 0.5
        double resultadoEsperado = 0.5;

        double resultado = _calc.CalcularTStudentDosMuestras(muestra1, muestra2);

        Assert.Equal(resultadoEsperado, resultado, 4);
    }

    // PRUEBA 6: Muestra vacía
    [Fact]
    public void CalcularMedia_MuestraVacia_LanzaExcepcion()
    {
        double[] muestra = { };

        Assert.Throws<ArgumentException>(() => _calc.CalcularMedia(muestra));
    }

    // PRUEBA 7: Muestra con un solo dato
    [Fact]
    public void CalcularVarianza_UnSoloDato_LanzaExcepcion()
    {
        double[] muestra = { 5 };

        Assert.Throws<ArgumentException>(() => _calc.CalcularVarianza(muestra));
    }

    // PRUEBA 8: Entrada nula
    [Fact]
    public void CalcularMedia_EntradaNula_LanzaExcepcion()
    {
        double[]? muestra = null;

        Assert.Throws<ArgumentException>(() => _calc.CalcularMedia(muestra!));
    }

    // PRUEBA 9: Verificar contra cálculo manual
    [Fact]
    public void CalcularTStudent_VerificadoManualmente_RetornaValorEsperado()
    {
        // ARRANGE - datos verificados manualmente
        double[] muestra = { 5, 7, 9, 11, 13 };
        double mediaPoblacional = 7.0;

        // Verificación manual:
        // Media muestral  = (5+7+9+11+13)/5 = 9
        // Varianza        = 10
        // Desv. estándar  = sqrt(10) = 3.1623
        // Error estándar  = 3.1623 / sqrt(5) = 1.4142
        // t               = (9 - 7) / 1.4142 = 1.4142
        double resultadoEsperado = 1.4142;

        // ACT
        double resultado = _calc.CalcularTStudent(muestra, mediaPoblacional);

        // ASSERT
        Assert.Equal(resultadoEsperado, resultado, 4);
    }

    // PRUEBA 10: Refactorización - el cambio interno no altera resultados
    [Fact]
    public void Refactorizacion_CambioInterno_NoAlteraResultados()
    {
        // ARRANGE
        double[] muestra = { 2, 4, 6, 8, 10 };
        double mediaPoblacional = 5.0;

        // ACT - ejecutamos todos los métodos para verificar consistencia
        double media = _calc.CalcularMedia(muestra);
        double varianza = _calc.CalcularVarianza(muestra);
        double desviacion = _calc.CalcularDesviacionEstandar(muestra);
        double tStudent = _calc.CalcularTStudent(muestra, mediaPoblacional);

        // ASSERT - verificamos que todos los resultados sean consistentes
        Assert.Equal(6.0, media);
        Assert.Equal(10.0, varianza);
        Assert.Equal(Math.Sqrt(10.0), desviacion);
        Assert.Equal(0.7071, tStudent, 4);
    }
}