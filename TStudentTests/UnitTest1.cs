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
}