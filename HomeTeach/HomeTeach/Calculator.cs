using System.Runtime.CompilerServices;

namespace HomeTeach;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Minus(int a, int b)
    {
        return a - b;
    }

    public int Multiplied(int a, int b)
    {
        return a * b;
    }

    public int Divided(int a, int b)
    {
        return a / b;
    }

    public int DividedWithException(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Can't Not Divided by 0");
        }
        return a / b;
    }

}