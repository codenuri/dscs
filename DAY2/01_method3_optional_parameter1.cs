using static System.Console;

// optional Parameter - 76
class Program
{
    // C++ : default parameter
    // C#  : optional parameter 이름만 다르고, 의미는 동일
    // Java : 지원 안함.
    public static void M1(int a, int b = 0, int c = 0)
	{
	 	WriteLine($"{a}, {b}, {c}");
	} 
    public static void Main()
    {
        M1(10, 20, 30); // 10, 20, 30
        M1(10, 20);	 	// 10, 20, 0
        M1(10);         // 10, 0,  0,

        // named argument 와 섞어서 사용가능합니다.
        M1(10, c: 30);  // 10, 0, 30
    }
    // 주의 사항: 마지막 인자부터 차례대로만 지정 가능 합니다.
    public static void M2(int a, int b = 0, int c ) {}     // error
    public static void M3(int a = 0, int b, int c = 0) { } // error
}