using static System.Console;

//class Point
struct Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

   
    public override bool Equals(object? obj)
    {
        // as 연산자는 reference type 만 가능 합니다.
        Point other = (Point)obj;

     
        return x == other.x;
    }
    public override int GetHashCode()
    {
        return x.GetHashCode() + y.GetHashCode();
    }
    
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        //Point p2 = p1;
        Point p2 = new Point(1, 1);

        // p1, p2 : 다른 객체, 동일 상태


        // value type 타입정리!
        // #1. == 연산자
        // => 기본적으로 사용할수 없음.
        // => 하지만 연산자 재정의로 제공 가능
        // => "Equals4.cs" 소스참고, 동일하게 만들면 됩니다.
        //      WriteLine($"{p1 == p2}"); 


        // #2. p1.Equals() 
        // => System.Object 의 구현 : == 을 사용해서 구현
        // => System.ValueType에서 override 되었음 : 2객체의 
        //                                      메모리를 통채로 비교
        //                                      bitwise compare

        // Equals 를 override 해서 구현 변경 가능 합니다.
        WriteLine($"{p1.Equals(p2)}"); 
    }
}
