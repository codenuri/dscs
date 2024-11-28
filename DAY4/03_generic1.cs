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

        // #1. 원리
        swap<int>(ref n1, ref n2); // 1. swap 틀에 int 를 넣어서
                                    //   swap(ref int, ref int) 메소드 생성  
                                    // 2. 이 위치는 "call swap(int, int)"

		swap<double>(ref d1, ref d2);
        // => 결국 위 2줄때문에 "swap" 메소드는 실제 2개가 생성됩니다.

        // #2. 타입인자를 전달해도 되고 생략해도 됩니다.
        swap<int>(ref n1, ref n2);  // 타입 인자 전달
        swap(ref n1, ref n2);       // 타입 인자 생략
    }
}