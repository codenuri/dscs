class Program
{
    public static void Main()
    {
        // C# 배열의 상속계층은
        // int[] => System.Array => System.Object 입니다.
        int[] x = { 1, 2, 3, 4, 5 };

        Array arr = x; // ok. Array 가 기반 클래스 이므로

    }
}
