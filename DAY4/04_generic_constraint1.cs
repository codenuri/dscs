using System;
using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // int 타입만 가능한 메소드
    /*
    public static int Max(int a, int b) 
    {
		return a < b ? b : a;
    }
    */

    // Max 를 Generic 으로 해보세요
    public static T Max<T>(T a, T b)
    {
//      return a < b ? b : a; // < 는 숫자 타입만 가능

        // CompareTo 는 int 와 string 모두 가능.
        // 하지만 에러 - 이유는 아래 Foo 참고
        return a.CompareTo(b) < 0 ? b : a;         
    }

    public static void Main()
    {
		WriteLine($"{Max(10, 20)}");
		WriteLine($"{Max("AAA", "CC")}");

        Foo(10, 20); 
    }
    public static void Foo<T>(T a, T b)
    {
        a.CompareTo(b); // a안에 CompareTo 가 있다는 보장이 없다.
                        // 그래서 error


        a.ToString(); // ok. 대부분의 타입에는 있다. onject 가 제공

        // 핵심
        // Generic 안에서는 인자에 대해서 object 타입으로
        // 가능한 연산만 할수 있다.

    }
}
