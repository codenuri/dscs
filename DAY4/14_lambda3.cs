using static System.Console;

class Program
{
	public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

		// lambda expression 활용

		// #1. 메소드의 인자로 전달
		// => 지역변수 캡쳐가 될수 있으므로 아주 편리합니다.
		int idx = Array.FindIndex(array, n => n % 2 == 0);


		// #2. Func 또는 Action 에 담아서 함수 처럼 사용
		Func<int, int> square = n => n * n;
		
		int ret = square(3);

		WriteLine($"{ret}");

    }
}
