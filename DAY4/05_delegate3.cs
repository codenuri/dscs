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
        // 결국 MyFunc 는 컴파일러가 만든 "class" 의 이름입니다.
        // => C#의 모든 객체는 new로 생성해야 합니다.
        // => 단, 표준 타입은 단축 표기로 해서 new  없이 가능
        // => delegate 도 단축 표기법 가능

        MyFunc f1 = new MyFunc(Foo); // 정확한 표기법(항상 생성)
        MyFunc f2 = Foo;             // 이 표기법도 허용
                                     // 이 표기법 권장(pool 에서 꺼내기)
                                     // string 의 intern pool 과 유사

        f1(10);          
        f1.Invoke(10);   
    }

    public static void Foo(int arg)
        => WriteLine($"Foo : {arg}");
}
