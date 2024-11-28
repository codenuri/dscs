using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

// delegate R MyFunc<R>(); // 정확한 타입만 가능 

delegate R MyFunc<out R>(); // 호환 가능한 타입이면 ok
							// MyFunc<Base> 에 MyFunc<Derived> 를 넣을수
							// 있다!


class Program 
{
	public static Derived CreateDerived() => new Derived();

	public static void Main()
	{	
		// f1은 "Derived 를 만들수 있는" 메소드를 담고 있습니다.
		// 즉, f1을 호출하면 Derived 가 생성됩니다.
		MyFunc<Derived> f1 = CreateDerived;

		// f2 에는 Base 를 만들수(반환하는) 있는 메소드를 담아야 합니다.
		// => f2() 를 호출하는 이유는 Base를 만들려고 하는것
		MyFunc<Base> f2;
		

		f2 = f1; // 되도 전혀 문제 없습니다.
				 // Base 가 필요한데, Derived 를 만들어 줘도 문제 될게 없습니다.



		Base b = f2();

		b.Method();
	}
}
