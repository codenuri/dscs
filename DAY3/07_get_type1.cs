using System;
using static System.Console;

// 121page ~

class Program
{
	public static void PrintType(object obj)
	{
		// obj 가 가리키는 객체의 실제 타입을 알고 싶다.	
		
		Type t = obj.GetType(); // obj 가 가리키는 객체에 대한 
								// 타입 정보를 꺼내는 메소드
		WriteLine($"{t.Name} {t.FullName} {t.BaseType}");								

	}

	public static void Main()
	{
		string s = "ABC";
		int    n = 10;
		PrintType(s);
		PrintType(n);
	}
}
