// class 도 Generic 으로 해도 됩니다.

class Point<T>
{
    //  private T x = 0;
    //  private T y = 0; // error. 임의 타입이 0으로 초기화 될수 없다.

    private T x = default(T);
    private T y = default;

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
        // generic class 는 타입인자 생략할수 없습니다.
        // 반드시 전달해야 합니다.
        Point<int> p1 = new Point<int>(1, 2);
        Point<double> p2 = new Point<double>(1.1, 2.2);
    }
}