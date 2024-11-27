using System.Collections;
using static System.Console;

// 02_override => 07_ToString.cs 
// 120 page ~ 




// ToString()
// => object �� �����ϴ� �޼ҵ� �̹Ƿ� ��κ��� Ÿ���� ������ �ִ�.
// => ��ü�� ���¸� ���ڿ��� ��� ������ ���
// => object Ŭ������ �⺻ ������ "Ÿ���̸�"�� ���ڿ��� ��ȯ

// �ٽ� : virtual method �̹Ƿ�
//       �Ļ� Ŭ���� �����ڰ� override �ؼ�
//		 ��ü�� ���¸� ���ڿ��� ��ȯ�Ҽ� �ֵ��� ����� �ȴ�.!

class Point 
{
	private int x = 0;
	private int y = 0;

	public Point(int a, int b) => (x, y) = (a, b);

    public override string ToString()
    {
		return $"{x}, {y}";
    }
}

class Program 
{
	public static void Main()
	{

		Point p = new Point(1, 2);
		
		string? s = p.ToString();

		WriteLine( s );

		WriteLine(p); // �̼��� p.ToString() �� ����� ȭ�� ��� 

		int[] x = { 1, 2, 3 };
		List<int> y = new List<int>();

		WriteLine(x);
        WriteLine(y);


    }
}
