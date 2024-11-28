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

// 아래 코드가 Example 클래스에 메소드를 추가한 코드
// 규칙 
// #1. static 클래스에 static method 로 만들어야 합니다.
// #2. static method 의 1번째 인자로 "this 메소드를 추가할 클래스이름"
// #3. 아래 코드에서 "MyExtension" 이름은 아무이름이나 사용해도 됩니다.

static class MyExtension
{
	public static void Goo(this Example e, int n)
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
		e.Goo(3);// 1. Example 에 Goo 가 있는지 검색
				 
				 // 2. 없다면 모든 static 클래스를 조사해서 
				 //    1번째 인자로 "this Example" 을 가진 static 메소드를 찾는다

				 // 3. 그리고 컴파일러가 "MyExtension.Goo(e, 3)" 으로 변경한것
	}
}

