namespace Calculadora.Tests;

using System.Numerics;
using Calculadora.Core;

public class UnitTestCalculadora
{
    [Fact]
    public void soma_simples()
    {
        Calculadora c = new Calculadora();
        double a = c.soma(1,2);

        Assert.Equal(3.0, a);
    }

    [Fact]
    public void soma_numero_negativo()
    {
        Calculadora c = new Calculadora();
        double a = c.soma(-1,2);

        Assert.Equal(1.0, a);
    }

    [Fact]
    public void soma_numero_float()
    {
        Calculadora c = new Calculadora();
        double a = c.soma(1.02,2.002);

        Assert.Equal(3.022, a);
    }

    [Fact]
    public void soma_numero_char()
    {
        Calculadora c = new Calculadora();

        Assert.Throws<ArgumentException>(() => {
            double a = c.soma('a', 'a');
        });

    }

}
