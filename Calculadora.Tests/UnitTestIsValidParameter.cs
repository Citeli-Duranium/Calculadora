namespace Calculadora.Tests;
using System.Reflection;
using Calculadora.Core;

public class UnitTestIsValidParameter
{

    [Fact]
    public void deve_retornar_true_para_int()
    {
        var c = new Calculadora();

        var method = typeof(Calculadora)
            .GetMethod("is_valid_parameter", BindingFlags.NonPublic | BindingFlags.Instance);

        var genericMethod = method.MakeGenericMethod(typeof(int));

        var result = (bool)genericMethod.Invoke(c, new object[] { 10 });

        Assert.True(result);
    }

    [Fact]
    public void deve_retornar_true_para_float()
    {
        var c = new Calculadora();

        var method = typeof(Calculadora)
            .GetMethod("is_valid_parameter", BindingFlags.NonPublic | BindingFlags.Instance);

        var genericMethod = method.MakeGenericMethod(typeof(float));

        var result = (bool)genericMethod.Invoke(c, new object[] { 10.0f });

        Assert.True(result);
    }

    [Fact]
    public void deve_retornar_true_para_double()
    {
        var c = new Calculadora();

        var method = typeof(Calculadora)
            .GetMethod("is_valid_parameter", BindingFlags.NonPublic | BindingFlags.Instance);

        var genericMethod = method.MakeGenericMethod(typeof(double));

        var result = (bool)genericMethod.Invoke(c, new object[] { 10.0d });

        Assert.True(result);
    }

    [Fact]
    public void deve_retornar_false_para_char()
    {
        var c = new Calculadora();

        var method = typeof(Calculadora)
            .GetMethod("is_valid_parameter", BindingFlags.NonPublic | BindingFlags.Instance);

        var genericMethod = method.MakeGenericMethod(typeof(char));

        var result = (bool)genericMethod.Invoke(c, new object[] { 'a' });

        Assert.False(result);
    }

    [Fact]
    public void deve_retornar_false_para_string()
    {
        var c = new Calculadora();

        var method = typeof(Calculadora)
            .GetMethod("is_valid_parameter", BindingFlags.NonPublic | BindingFlags.Instance);


        Assert.Throws<System.ArgumentException>(() => {
            var genericMethod = method.MakeGenericMethod(typeof(string));
            var result = (bool)genericMethod.Invoke(c, new object[] { "teste" });
        });
    }
}