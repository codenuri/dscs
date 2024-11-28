using System;
using static System.Console;

// 핵심 #1. delegate 만드는 법 정확히 알아 두세요
// => 1. 메소드 선언 모양을 만들고
// => 2. 반환타입 앞에 "delegate" 추가
// => 3. 메소드 이름을 원하는 "타입이름" 으로 변경

delegate void MyFunc(int arg);

class Program
{
	public static void Main()
	{
        MyFunc f = Foo;  // f는 Foo 의 호출 정보(메소드 주소 와 객체정보)
						 // 를 담게 됩니다.

		f(10);			// Foo(10)
		f.Invoke(10);	// Foo(10)
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
