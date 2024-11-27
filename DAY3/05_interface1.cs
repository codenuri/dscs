using static System.Console;

// 112 page ~ 

// 핵심 : C#은 다양한 타입에서 공통으로 사용되는 메소드는 
// #1. 인터페이스를 먼저 설계하고
// #2. 해당 타입 설계시 인터페이스를 구현하는 문법으로 만들어져 있습니다.
// 그래서 아래 같은 메소드 작성이 가능합니다

void Foo(IComaprable c) 
{
	// 이 메소드는 CompareTo 메소드가 가 있는 객체만 인자로 받을수 있습니다.
}


class Program 
{
	public static void Main()
	{
		int n1 = 10;
		int n2 = 20;

		string s1 = "AAA";
		string s2 = "BBB";

		// 크기를 비교하는 방법. 
		// #1. 비교 연산자(<, >,...) 사용
		// => 숫자 타입(정수, 실수) 만 가능.
		bool b1 = n1 < n2;
//      bool b2 = s1 < s2;  // error

		// #2. CompareTo 메소드 사용
		// => 크기 비교가 가능한 대부분의 타입에서 지원
		int ret1 = n1.CompareTo(n2); // ok
        int ret2 = s1.CompareTo(s2); // ok.
									 // s1이 크면 결과는 양수
									 // s2가 크면 결과는 음수
									 // 같으면 0
									 // C언어 strcmp 와 동일!

		M1(n1);
		M1(s1);
    }

	// 아래 메소드는 CompareTo 메소드가 있는 타입의 모든 객체를 인자로 
	// 받을수 있습니다.
	public static void M1(IComparable ic)
	{
	}

}
