using System;
using static System.Console;



delegate void MyFunc(int arg);

// delegate 원리
// => 위처럼 규칙(문법)에 맞게 코드를 작성하면
// => 컴파일러가 아래 클래스를 생성합니다.
// => 참고, "MulticastDelegate" 로 부터 상속받는 클래스를
//          사용자가 직접 만들수는 없습니다.
// => 이 코드를 빌드하세요. ILASM 에서 DAY4.dll 열어보세요

/*
class MyFunc : MulticastDelegate
{
    // 반환값이 void 이고 인자가 int 한개인 
    // 메소드 주소를 저장할 때 필요한 코드 추가

    public void Invoke(int arg) { 저장된 주소의 메소드 호출}

    // operator() 연산자도 제공
}
*/


class Program
{
    public static void Main()
    {
        MyFunc f = Foo;  // f는 Foo 의 호출 정보(메소드 주소 와 객체정보)
                         // 를 담게 됩니다.

        f(10);          // Foo(10)
        f.Invoke(10);   // Foo(10)
    }

    public static void Foo(int arg)
        => WriteLine($"Foo : {arg}");
}
