using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base {}

// 반환 타입 이야기가 아니라..
// 인자 이야기 입니다. 
//delegate void MyAction<T>(T obj); // 이렇게 하면 정확한 타입만 가능
delegate void MyAction<T>(in T obj); // 호환 가능한타입은 ok. 

class Program 
{
	public static void UseBase(Base b) { b.Method(); }

	public static void Main()
	{	
		// f1에는 인자로 Base 객체를 받는 메소드를 담을수 있습니다.
		// => f1사용시 Base 객체를 보내겠다는 의도
		MyAction<Base>    f1 = UseBase;

        // f2에는 인자로 Derived 객체를 받는 메소드를 담을수 있습니다.
		// => 즉, 인자로 Derived 를 보내 겠다는 의도.. 
        MyAction<Derived> f2;
		
		f2 = f1;  // 결국 f2 는 UseBase 를 담게 됩니다.
                  // 즉, UseBase() 는 Base 객체가 필요 합니다.

        f2(new Derived()); // Base 객체가 필요한데.
						   // DErived 를 전달..
						   // 하지만 문제되지 않습니다.

    }
}