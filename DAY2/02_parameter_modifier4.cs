using static System.Console;

class Program
{
	// ref 로 할지 ? out 으로 할지 잘 생각해 보세요
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

		// 아래 결과가 2, 1이 나오도록 Swap 을 만들어 보세요
		WriteLine($"{x}, {y}");	// 2, 1
				
	}
}