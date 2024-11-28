using System;
using static System.Console;

// delegate ( 156 ~ )

class Program
{
	public static void Main()
	{
		// ? 위치에 들어갈 타입을 생각해 보세요
		int    n = 10;
		double d = 3.4;
		string s = "abc";

		? f = Foo;  // ? 는 메소드를 담는 타입
					// 정확히는 "메소드의 호출 정보"를 담는 타입
					// => "delegate"
					// => C/C++ 의 함수 포인터
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
