namespace Calculadora.Tests;

using Calculadora.Core;

public class UnitTestDiv
{
    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(-6, 2, -3)]
    [InlineData(-6, -2, 3)]
    public void div_quando_recebe_inteiros_deve_retornar_resultado_correto(int a, int b, int esperado)
    {
        var c = new Calculadora();

        var result = c.div(a, b);

        Assert.Equal(esperado, result);
    }

    [Theory]
    [InlineData(3.0f, 2.0f, 1.5f)]
    [InlineData(-3.0f, 2.0f, -1.5f)]
    public void div_quando_recebe_float_deve_retornar_valor_com_precisao(float a, float b, float esperado)
    {
        var c = new Calculadora();

        var result = c.div(a, b);

        float tolerancia = 0.000001f;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Theory]
    [InlineData(3.0, 2.0, 1.5)]
    [InlineData(-3.0, 2.0, -1.5)]
    public void div_quando_recebe_double_deve_retornar_valor_com_precisao(double a, double b, double esperado)
    {
        var c = new Calculadora();

        var result = c.div(a, b);

        double tolerancia = 0.00000001;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Fact]
    public void div_quando_divisor_e_zero_deve_lancar_divide_by_zero_exception()
    {
        var c = new Calculadora();

        Assert.Throws<DivideByZeroException>(() =>
        {
            c.div(10, 0);
        });
    }

    [Fact]
    public void div_quando_divisor_float_e_zero_deve_lancar_divide_by_zero_exception()
    {
        var c = new Calculadora();

        Assert.Throws<DivideByZeroException>(() =>
        {
            c.div(10.0f, 0.0f);
        });
    }

    [Fact]
    public void div_quando_divisor_double_e_zero_deve_lancar_divide_by_zero_exception()
    {
        var c = new Calculadora();

        Assert.Throws<DivideByZeroException>(() =>
        {
            c.div(10.0, 0.0);
        });
    }

    [Fact]
    public void div_quando_recebe_tipo_invalido_deve_lancar_exception()
    {
        var c = new Calculadora();

        Assert.Throws<ArgumentException>(() =>
        {
            c.div('a', 'a');
        });
    }
}