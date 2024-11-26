using static System.Console;

class Program
{
    // ref 로 할지 ? out 으로 할지 잘 생각해 보세요
    // => swap 은 R/W 가 모두 가능해야 합니다.
    // => out 이 아닌 ref 사용!!
    /*
	public static void Swap(ref int a, ref int b)
	{
		int t = a;
		a = b;
		b = t;
	}
	*/
	// 아래 코드가 C#의 generic(template) 입니다. 내일 자세히 
    public static void Swap<T>(ref T a, ref T b)
    {
        int t = a;
        a = b;
        b = t;
    }

    public static void Main()
	{
		int x = 1;
		int y = 2;

		Swap(ref x, ref y); // swap(&x, &y)

		// 아래 결과가 2, 1이 나오도록 Swap 을 만들어 보세요
		WriteLine($"{x}, {y}");	// 2, 1
				
	}
}