namespace Calculadora.Tests;

using Calculadora.Core;

public class UnitTestMult
{
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-1, 2, -2)]
    [InlineData(-2, -3, 6)]
    public void mult_quando_recebe_inteiros_deve_retornar_resultado_correto(int a, int b, int esperado)
    {
        var c = new Calculadora();

        var result = c.mult(a, b);

        Assert.Equal(esperado, result);
    }

    [Theory]
    [InlineData(1.5f, 2.0f, 3.0f)]
    [InlineData(-1.2f, 2.0f, -2.4f)]
    public void mult_quando_recebe_float_deve_retornar_valor_com_precisao(float a, float b, float esperado)
    {
        var c = new Calculadora();

        var result = c.mult(a, b);

        float tolerancia = 0.000001f;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Theory]
    [InlineData(1.5, 2.0, 3.0)]
    [InlineData(-1.02, 2.0, -2.04)]
    public void mult_quando_recebe_double_deve_retornar_valor_com_precisao(double a, double b, double esperado)
    {
        var c = new Calculadora();

        var result = c.mult(a, b);

        double tolerancia = 0.00000001;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Theory]
    [InlineData(0, 5, 0)]
    [InlineData(5, 0, 0)]
    public void mult_quando_um_dos_valores_e_zero_deve_retornar_zero(int a, int b, int esperado)
    {
        var c = new Calculadora();

        var result = c.mult(a, b);

        Assert.Equal(esperado, result);
    }

    [Fact]
    public void mult_quando_recebe_tipo_invalido_deve_lancar_exception()
    {
        var c = new Calculadora();

        Assert.Throws<ArgumentException>(() =>
        {
            c.mult('a', 'a');
        });
    }
}