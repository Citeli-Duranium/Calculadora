namespace Calculadora.Tests;

using System.Numerics;
using Calculadora.Core;

public class UnitTestSub
{
    [Fact]
    public void sub_simples()
    {
        Calculadora c = new Calculadora();
        int a = c.sub(1,2);

        Assert.Equal(-1, a);
    }

    [Fact]
    public void sub_numero_negativo()
    {
        Calculadora c = new Calculadora();
        int a = c.sub(-1,2);

        Assert.Equal(-3, a);
    }

    [Fact]
    public void sub_numero_float()
    {
        Calculadora c = new Calculadora();
        float var1 = 1.2f;
        float var2 = 2.3f;
        float result = c.sub(var1, var2);

        float tolerancia = 0.000001f;
        float expected = -1.1f;
        Assert.InRange( result, expected-tolerancia, expected+tolerancia );
    }

        [Fact]
    public void sub_numero_double()
    {
        Calculadora c = new Calculadora();
        double var1 = 1.02;
        double var2 = 2.002;
        double result = c.sub(var1, var2);

        double tolerancia = 0.00000001;
        double expected = -0.982;
        Assert.InRange( result, expected-tolerancia, expected+tolerancia );
    }


    [Fact]
    public void sub_numero_char()
    {
        Calculadora c = new Calculadora();

        Assert.Throws<ArgumentException>(() => {
            double a = c.sub('a', 'a');
        });

    }

}
