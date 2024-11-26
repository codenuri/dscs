using static System.Console;

class Program
{
	// modifier 가 없는 경우
	// => 인자의 복사본 생성
	public static void no_modifier_parameter(int x)
	{
		int n = x; // Read 작업 ok
		x = 0;	   // Write 작업 ok.
				   // 단, 복사본에 작업한것 
	}

	// out parameter
	// => 쓰기 작업만 하겠다는 것.
	// => 담아주기만 하겠다.
	// => 초기화 되지 않은 변수도 받을수 있다.
	public static void out_parameter(out int x)
	{
//		int n = x;	// error. Read 안됨
		x = 0;		// ok. Write만 가능
					// 이 코드가 없다면 에러!!
					// out parameter 사용시 반드시 Write 코드가 있어야한다
	}

	// ref modifier
	// => R/W 모두 하겠다는 의도
	// => Read 가능하므로 반드시 초기화 된 변수만 전달 가능. 
	// => 사용하지 않아도 에러는 아님.
	public static void ref_parameter(ref int x)
	{
		int n = x;	// ok. read 가능
		x = 0;		// ok. write 가능
					// 이 2줄이 없어도 에러 아님
	}

	public static void Main()
	{
		int n1;		// 초기화 안된 변수
		int n2 = 0;	// 초기화된 변수

		out_parameter(out n1); // ok
		out_parameter(out n2); // ok

		ref_parameter(ref n1); // error
		ref_parameter(ref n2); // ok

		out_parameter(out int n3); // out 만 가능.!!
									// 인자 전달 위치에서
									// 변수 선언
	}
}