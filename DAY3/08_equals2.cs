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

		// p1, p2 : ���� ��ü
		// p3, p4 : �ٸ� ��ü, ���°� ����

		// refeference Ÿ������!
		// #1. == ������
		WriteLine($"{p1 == p2}");
        WriteLine($"{p3 == p4}");
    }
}
