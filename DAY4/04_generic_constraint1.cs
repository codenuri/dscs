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
    public static int Max(int a, int b)
    {
        return a < b ? b : a;
    }

    public static void Main()
    {
		WriteLine($"{Max(10, 20)}");
		WriteLine($"{Max("AAA", "CC")}");

    }
}
