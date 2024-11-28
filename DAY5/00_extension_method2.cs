class Example { public void M1() {} }

static class MyExtension 
{
	// 아래 2개 메소드는 그냥, static 클래스에 static 메소드 입니다.
	public static void M2( this Example obj ) {}
	public static void M3( Example obj ) {}
}

class Program
{
	public static void Main()
	{
		Example e = new();
		e.M1();

		// M2, M3 는 static 클래스의 static 메소드이므로 아래 처럼 호출 가능
		MyExtension.M2(e); // ok
		MyExtension.M3(e); // ok

		e.M2();	// ok      이렇게 사용하기 위해서 this 가 필요!!
		e.M3(); // error.  this 가 없다.

	}
}
