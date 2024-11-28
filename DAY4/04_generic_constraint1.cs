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
    // int Ÿ�Ը� ������ �޼ҵ�
    /*
    public static int Max(int a, int b) 
    {
		return a < b ? b : a;
    }
    */

    // Max �� Generic ���� �غ�����
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
