// class �� Generic ���� �ص� �˴ϴ�.

class Point<T>
{
    //  private T x = 0;
    //  private T y = 0; // error. ���� Ÿ���� 0���� �ʱ�ȭ �ɼ� ����.

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
        // generic class �� Ÿ������ �����Ҽ� �����ϴ�.
        // �ݵ�� �����ؾ� �մϴ�.
        Point<int> p1 = new Point<int>(1, 2);
        Point<double> p2 = new Point<double>(1.1, 2.2);
    }
}