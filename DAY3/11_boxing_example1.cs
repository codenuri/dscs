using System;
using static System.Console;

struct Temperature : IComparable 
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(object? obj)
    {   
        if (obj == null) return 1; // 비교 대상이 null 이면 부조건 크다

        if (obj is Temperature t)
            return Value.CompareTo(t.Value);
        else
            // obj 가 가리키는 것이 Temperature 타입이 아닐때
            throw new ArgumentException("Bad Argument");
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(3.3);

        Console.WriteLine($"{t1.CompareTo(t2)}");
    }
}


