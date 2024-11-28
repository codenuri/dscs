using static System.Console;

class Program 
{
	public static void Main()
	{
		int[] x = {1, 8, 6, 4, 3};

		// Array 클래스 : 모든 종류 배열의 기반 클래스
		//				  배열관련 다양한 작업을 위한 static method제공
		
		// #1. sort 하려면
//		Array.Sort(x);


        // #2. 배열에서 선형 검색
        // IndexOf : 값 검색, 2번째 인자로 값전달
        int ret1 = Array.IndexOf(x, 3);		
		WriteLine($"{ret1}");  // 4


		// 배열에서 처음나오는 "3의 배수"를 찾고 싶다
		// FindIndex : 조건 검색, 2번째 인자로 메소드 전달
		//			   메소드는 인자 한개이고, bool 반환해야 한다.
		int ret2 = Array.FindIndex(x, Foo);
        
		WriteLine($"{ret2}"); // 2
    }
	public static bool Foo(int a)
	{
		return a % 3 == 0;
	}

}