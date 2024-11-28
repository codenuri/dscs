using static System.Console;

// lambda expression - 170 page

class Program
{
    static bool IsEven(int n) { return n % 2 == 0; }

	public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

        // int idx = Array.FindIndex(array, IsEven);


        // 람다 표현식(lambda expresion)
        // => 익명의 메소드(함수)를 만드는 문법
        // => 아래 한줄이 위 한줄과 완전히 동일합니다.
        // 장점 1. 가독성이 좋고, 코드 관리도 쉽다.
        // 장점 2. Closure!!!(지역변수 캡쳐) - 2번예제
        int idx = Array.FindIndex(array, n => n % 2 == 0 );


        WriteLine($"{idx}");	// 3	
    }
}
