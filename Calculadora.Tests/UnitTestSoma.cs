namespace Calculadora.Tests;

using Calculadora.Core;

public class UnitTestSoma
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 2, 1)]
    public void soma_quando_recebe_inteiros_deve_retornar_soma_correta(int a, int b, int esperado)
    {
        var c = new Calculadora();

        var result = c.soma(a, b);

        Assert.Equal(esperado, result);
    }

    [Theory]
    [InlineData(1.2f, 2.2f, 3.4f)]
    public void soma_quando_recebe_float_deve_retornar_valor_com_precisao(float a, float b, float esperado)
    {
        var c = new Calculadora();

        var result = c.soma(a, b);

        float tolerancia = 0.000001f;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Theory]
    [InlineData(1.02, 2.002, 3.022)]
    public void soma_quando_recebe_double_deve_retornar_valor_com_precisao(double a, double b, double esperado)
    {
        var c = new Calculadora();

        var result = c.soma(a, b);

        double tolerancia = 0.00000001;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Fact]
    public void soma_quando_recebe_tipo_invalido_deve_lancar_exception()
    {
        var c = new Calculadora();

        Assert.Throws<ArgumentException>(() =>
        {
            c.soma('a', 'a');
        });
    }
}