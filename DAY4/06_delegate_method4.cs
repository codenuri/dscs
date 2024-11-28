using static System.Console;

// multicast 
delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
	public static void SMethod(int arg) => WriteLine("Program.SMethod");

	public static void Main()
	{	
		Test t = new Test();

		MyFunc f = Test.SMethod; // 첫번째 메소드 등록

		// += 로 여러개 메소드 등록가능합니다. 
		f += t.IMethod;
		f += Program.SMethod;

		f(10); // 등록된 순서로 호출

		f -= t.IMethod; // 제거
		f(10);
	}
}
