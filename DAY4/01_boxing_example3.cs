// github.com/codenuri/dscs   DAY4.zip
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;



struct Temperature : IComparable, 
                     IComparable<Temperature>, 
                     IEquatable<Temperature>
{
    private double Value { set; get; } = 0;

    public Temperature(double val) => Value = val;

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;

        if ( obj is Temperature other)
            return Value.CompareTo(other.Value);
        else
           throw new ArgumentException("Object is not a Temperature");      
    }

    public int CompareTo(Temperature other)
    {
        return Value.CompareTo(other.Value);
    }

    public override bool Equals( object? obj)
    {
        return Value == ((Temperature)obj).Value;
    }

    public bool Equals(Temperature other)
    {
        return Value == other.Value;
    }
}

class Program
{
    public static void Main()
    {
        Temperature t1 = new Temperature(5.5);
        Temperature t2 = new Temperature(5.5);

        // 2개 온도를 비교하는 Equals() 가상함수
        // => value type 은 override 하지 않아도 메모리 내용 자체를 비교
        // => 비교정책을 변경하려면 Equals() 를 override 하면 된다.
        WriteLine($"{t1.Equals(t2)}");
    }
}


