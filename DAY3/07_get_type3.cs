using System;
using static System.Console;

class Program
{	
	public static void Foo(object obj)
	{
		// 타입 이름 출력
		Type t = obj.GetType();

		WriteLine($"{t.Name}");

		// obj 가 int 인지 확인하고 싶다.
		Type t1 = obj.GetType();
		Type t2 = typeof(int);

		if (t1 == t2) { }  // int!!

		if (obj is int) { } // 이코드가 내부적으로 위처럼 동작 하는 것
							// 위처럼 하지말고, 이렇게 하면 됩니다.
							// 그런데, 원리는 알아두세요

    }

	public static void Main()
	{
		int n = 10;
		string s = "ABC";

		Foo(n);
		Foo(s);
	}
}