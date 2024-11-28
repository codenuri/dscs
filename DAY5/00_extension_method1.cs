// github.com/codenuri/dscs 에서 DAY5.zip

using static System.Console;

// extension method( 115p ~ )



// 기존에 존재하는 클래스에 메소드를 추가하고 싶다.
// #1. 상속 문법 사용 
// => 추가된 메소드를 사용하려면 "파생 클래스이름" 을 사용해야 한다.

// #2. Extension method 문법 사용
// => 기존 클래스 이름을 계속 사용가능

class Example 
{
	public void Foo() => WriteLine("Example Foo");
}

// 아래 코드가 Example 클래스에 메소를 추가한 코드
static class MyExtension
{
	public static void Goo(this Example e)
	{
		Console.WriteLine("Example Goo");
	}
}


class Program
{
	public static void Main()
	{
		Example e = new();
		e.Foo();
		e.Goo(3); // ?
	}
}

