using System.Numerics;

namespace Calculadora.Core;

public class Calculadora
{
    public Calculadora() {}

    public T soma<T>(T a, T b) where T: INumber<T>
    {
        if (!(this.is_valid_parameter(a) || this.is_valid_parameter(b)))
        {
            throw new ArgumentException("Argumento não é numérico");
        }
        
        return a + b;
    }

    public T sub<T>(T a, T b) where T: INumber<T>
    {
        if (!(this.is_valid_parameter(a) || this.is_valid_parameter(b)))
        {
            throw new ArgumentException("Argumento não é numérico");
        }
        
        return a - b;
    }


    public T mult<T>(T a, T b) where T: INumber<T>
    {
        return a * b;
    }

    public T div<T>(T a, T b) where T: INumber<T>
    {
        return a / b;
    }

    private bool is_valid_parameter<T>(T param) where T: INumber<T>
    {
        Type[] permited_types = { 
            typeof(int), 
            typeof(float), 
            typeof(double),
            typeof(short),
            typeof(uint),
            typeof(long),
            typeof(ulong), 
            typeof(decimal)
        };

        Type param_type = typeof(T);

        foreach (Type type in permited_types)
        {
            if(type == param_type)
                return true;
        }

        return false;
    }


}
