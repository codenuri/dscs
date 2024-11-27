using static System.Console;

//class Point
struct Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    /*
    public override bool Equals(object? obj)
    {
        Point? other = obj as Point;
        if (other == null) return false;
        return x == other.x && y == other.y;
    }
    public override int GetHashCode()
    {
        return x.GetHashCode() + y.GetHashCode();
    }
    */
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        // p1, p2 : 다른 객체, 동일 상태


        // value type 타입정리!
        // #1. == 연산자
        
        WriteLine($"{p1 == p2}"); 


        // #2. 
        WriteLine($"{p1.Equals(p2)}"); 
    }
}
