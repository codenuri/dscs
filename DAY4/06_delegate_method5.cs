delegate void MyFunc(int arg);

class Program
{
	public static void M1(int arg)    {}
	
	public static void Main()
	{
		MyFunc f = M1;

		// f 를 사용해서 메소드를 호출할때 아래의 2가지 방법이 가능합니다.
		f(10);			// #1. () 연산자
		f.Invoke(10);	// #2. Invoke() 메소드

		// delegate 는 reference type(class) 이므로 null 될수 있습니다.
		f = null;

//      f(10); // runtime error

		if (f != null)	// 이 코드가 안전한 코드
			f(10);

		// 위 2줄을 간단하게 하는 연산자는 ?
		f?(10);        // error 이지만
		f?.Invoke(10); // 이 표기법은 에러가 아니다.
					   // 그래서, Invoke() 를 사용하는 경우가 많습니다.

		f?.Invoke(10); // f 가 null 이면 아무일도 안함
					   //      null 이 아니면 등록된 메소드 호출	
	}
}
