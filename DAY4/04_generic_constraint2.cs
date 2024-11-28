using System;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // Generic 안에서 object 로 할수 있는 작업외에
    // 어떤 연산을 하고 싶다면
    // 방법 #1. generic constraint(제약) 사용
    // => 모든 타입에 동작(메소드 생성한다는 의미)하는 메소드가 아닌
    // => 조건(constraint)를 만족하는 경우만 사용가능하다는 것
    public static T Max1<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    // 방법 #2. 캐스팅
    // => 아래 처럼 해도 에러는 없습니다.
    // => 그런데.. 
    public static T Max2<T>(T a, T b) 
    {
        IComparable ia = (IComparable)a;
        IComparable ib = (IComparable)b;

        return ia.CompareTo(ib) < 0 ? b : a;
    }

    public static void Main()
    {   
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        WriteLine($"{Max1(10, 20)}");
        WriteLine($"{Max1("AAA", "CC")}");

        //      Max1(p1, p2);   // 컴파일 에러. IComparable 을 구현하지 않은 타입
        Max2(p1, p2);
        Max2(10, 20);
    }

}
