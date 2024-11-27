using static System.Console;

struct Point
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;

	public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main()
	{
		Point p = new Point(1, 1);
		
		WriteLine($"{object.ReferenceEquals(p, p)}"); // False

		// 아래 한줄의 메모리 그림을 생각해 보세요 - 141page
        WriteLine($"{MyReferenceEquals(p, p)}"); // False
    }

    public static bool MyReferenceEquals(object? a, object? b)
    {
        return a == b;
    }
}