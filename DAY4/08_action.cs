// non-generic 클래스와 generic 클래스의 이름이 같아도 충돌 아닙니다.(구별가능)
// generic 클래스 끼리도 타입 인자갯수가 다르면 같은 이름 가능합니다.

/*
 * 아래 Action 이 이미 C# 표준에 있습니다.
 * 인자가 16개까지 지원 됩니다.
delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);
*/

class Program 
{
	public static void M1(){}
	public static void M2(int arg){}
	public static void M3(double arg){}
	public static void M4(int arg1, double arg2){}

	public static void Main()
	{
        Action f1 = M1;
        Action<int> f2 = M2;
        Action<double> f3 = M3;
        Action<int, double> f4 = M4;

    }
}
