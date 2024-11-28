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
    // Generic �ȿ��� object �� �Ҽ� �ִ� �۾��ܿ�
    // � ������ �ϰ� �ʹٸ�
    // ��� #1. generic constraint(����) ���
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
