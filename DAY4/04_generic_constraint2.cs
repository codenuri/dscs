using System;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // Generic 안에서 object 로 할수 있는 작업외에
    // 어떤 연산을 하고 싶다면
    // 방법 #1. generic constraint(제약) 사용
    public static T Max1<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
        WriteLine($"{Max1(10, 20)}");
        WriteLine($"{Max1("AAA", "CC")}");
    }

}
