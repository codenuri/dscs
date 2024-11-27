using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
	public static void Main() 
	{
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// p1, p2 : 동일 객체
		// p3, p4 : 다른 객체, 상태가 동일

		// refeference 타입정리!
		// #1. == 연산자
		WriteLine($"{p1 == p2}");
        WriteLine($"{p3 == p4}");
    }
}
