namespace TStudentTests;

public class TStudentCalculatorTests
{
    private readonly TStudentLib.TStudentCalculator _calc;

    public TStudentCalculatorTests()
    {
        _calc = new TStudentLib.TStudentCalculator();
    }

    // PRUEBA 1: Media
    [Fact]
    public void CalcularMedia_ConDatosValidos_RetornaMediaCorrecta()
    {
        double[] muestra = { 2, 4, 6, 8, 10 };
        double resultadoEsperado = 6.0;

        double resultado = _calc.CalcularMedia(muestra);

        Assert.Equal(resultadoEsperado, resultado);
    }
}


