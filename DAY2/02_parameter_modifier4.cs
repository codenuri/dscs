using static System.Console;

class Program
{
	// ref �� ���� ? out ���� ���� �� ������ ������
	public static void Swap(?, ?)
	{
		int t = a;
		a = b;
		b = t;
	}

	public static void Main()
	{
		int x = 1;
		int y = 2;

		Swap(?);

		// �Ʒ� ����� 2, 1�� �������� Swap �� ����� ������
		WriteLine($"{x}, {y}");	// 2, 1
				
	}
}