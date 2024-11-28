class Point
{
    public int x = 0;
    public int y = 0;

    public void Set(int a, int b) => (x, y) = (a, b);

    // 핵심 : Foo 는 static method
    // 사용자 코드                 // 컴파일러가 추가한 코드
    //                            // 핵심 : this 추가 안됨
    public static void Foo(int a) // void Foo(int a)
    {
        x = a;        // error     //    this.x = a 가 되어야 하고
        Set(10, 20);  // error     //    this.Set(10,20) 이 되야 하지만
                                  //   Foo 는 this 가 없다.
                                  // 그래서, static method 에서는
                                  // instance 필드(메소드) 접근 안됨.

        Program.Goo();  // ok
        Goo();          // 컴파일러가 Program.Goo()

    }

    public static void Goo() { }
}

class Program
{
    public static void Main()
    {
        // static method 핵심 : 객체없이 호출가능. 클래스 이름으로 호출
        Point.Foo(10);  // 컴파일러가 변경한 코드도
                        // Point.Foo(10)
                        // 즉, 인자로 전달되는 객체 없습니다.

    }
}