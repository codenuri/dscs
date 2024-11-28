/*
delegate R Func<R>();
delegate R Func<T, R>(T arg);
delegate R Func<T1, T2, R>(T1 arg1, T2 arg2);
*/
class Program 
{
	public static int    M1() => 0;
	public static double M2(int arg) => 0;
	public static string M3(double arg) => "";
	public static object M4(int arg1, double arg2) => 0;

	public static void Main()
	{
		Func<int> f1 = M1;
		Func<int, double> f2 = M2;
		Func<double, string> f3 = M3;
		Func<int, double, object> f4 = M4;		
	}
}

// 반환값이 있다는 것은 "인자를 가지고 연산을 수행하고 결과를 반환"
// => "함수 라는 개념과 완전히 동일"
// => 그래서 이름이 Func(Function 의 약자)

// 반환값이 없다는 것은 
// => 어떤 일반 수행한다.
// => 동작만 있다는 것
// => 그래서 이름이 Action