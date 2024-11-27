using static System.Console;

// 112 page ~ 


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
