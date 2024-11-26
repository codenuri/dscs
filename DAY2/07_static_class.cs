class Ex1
{
    public static void M1() { }
    public static void M2() { }
}

// static class : C# 에만 있는 문법(C++없음)
// => 모든 메소드가 static 인 경우.
// => 객체를 생성할수 없다.
static class Ex2
{
    public static void M1() { }
    public static void M2() { }
}

class Program
{
    public static void Main()
    {
        // #1. Ex1 의 모든 메소드는 static 이므로 객체 없이 사용가능합니다.
        Ex1.M1();
        Ex1.M2();

        // #2. 하지만 Ex1 의 객체를 생성해도 에러는 아닙니다.
        Ex1 ex1 = new Ex1(); // ok
        Ex2 ex2 = new Ex2(); // error.

    }
}