// generic (147 ~ )

class Program
{
    /*
    public static void swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    public static void swap(ref double a, ref double b)
    {
        double tmp = a;
        a = b;
        b = tmp;
    }
    */

    // 인자의 타입만 다르고 구현이 동일하다면
    // 메소드를 만들지 말고
    // 메소드를 만드는 틀을 만들자! => Generic, Template 이라는 기술
    public static void swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10,  n2 = 20;
        double d1 = 1.1, d2 = 2.3;

        swap<int>(ref n1, ref n2);
		swap<double>(ref d1, ref d2);
    }
}