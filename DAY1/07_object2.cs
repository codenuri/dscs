using static System.Console;

// System.Object
// => C#의 대부분의 타입은 System.Object 로 부터 상속 받게 됩니다.
// => 7개의 메소드를 가진 클래스
// => ref struct 라는 것으로 만든 타입은 예외(C#9.0 ~ )

// 사용자 코드		// 컴파일러가 변경한 코드
class Car			// class Car  : System.Object
{	
}

class Program
{
	public static void Main()
	{
		Car c = new Car();
		
		

		WriteLine( c.ToString() ); // ok

		object o = c;
	}
}
