using System;

// 날짜 개념 : 상태(데이타, 필드) + 동작( 메소드, 함수) 이 있습니다
//            => 클래스로 설계

// 사인값 구하기, 제곱 구하기 : 
//          => 데이타가 필요 없습니다. 
//          => 클래스가 아닌 일반 함수로 해도 충분합니다.
//          => C#, Java 는 일반함수를 만들수 없습니다.
//          => 오직 클래스만 가능

// C# 에 아래와 같은 클래스가 이미 있습니다.
/*
static class Math
{
    public static int Square(int x) => x* x;
    public static int Add(int a, int b) => a + b;
}
*/

class Program
{
    public static void Main()
    {
        double ret = Math.Sqrt(2);

        // 대표적인 static class 가 Math, Console 입니다.

        Math m = new Math(); // error
        Console c = new Console(); // error

        // Console 클래스의 모든 메소드는 static 입니다.
        // =>그래서 "Console.메소드이름" 으로 사용한것!!!
    }
}