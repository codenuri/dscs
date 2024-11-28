// class 도 Generic 으로 해도 됩니다.

class Point<T>
{
    private T x = 0;
    private T y = 0;

    public Point(T a, T b)
    {
        x = a;
        y = b;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1.1, 2.2);
    }
}