namespace Calculadora.Tests;

using Calculadora.Core;

public class UnitTestSub
{
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(-1, 2, -3)]
    public void sub_quando_recebe_inteiros_deve_retornar_resultado_correto(int a, int b, int esperado)
    {
        var c = new Calculadora();

        var result = c.sub(a, b);

        Assert.Equal(esperado, result);
    }

    [Theory]
    [InlineData(1.2f, 2.3f, -1.1f)]
    public void sub_quando_recebe_float_deve_retornar_valor_com_precisao(float a, float b, float esperado)
    {
        var c = new Calculadora();

        var result = c.sub(a, b);

        float tolerancia = 0.000001f;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Theory]
    [InlineData(1.02, 2.002, -0.982)]
    public void sub_quando_recebe_double_deve_retornar_valor_com_precisao(double a, double b, double esperado)
    {
        var c = new Calculadora();

        var result = c.sub(a, b);

        double tolerancia = 0.00000001;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }

    [Fact]
    public void sub_quando_recebe_tipo_invalido_deve_lancar_exception()
    {
        var c = new Calculadora();

        Assert.Throws<ArgumentException>(() =>
        {
            c.sub('a', 'a');
        });
    }

    [Theory]
    [InlineData(1, 2.2f, -1.2)]
    public void sub_quando_recebe_tipos_mistos_deve_retornar_double_com_precisao(int a, float b, double esperado)
    {
        var c = new Calculadora();

        double result = c.sub(a, b);

        double tolerancia = 0.000001;
        Assert.InRange(result, esperado - tolerancia, esperado + tolerancia);
    }
}