class Program
{
    public static void Main()
    {
        M1(new int[] { 1, 2 }, 3); // ok

        M2(1, 2, 3);

        M3(1, 2, 3);
    }

    // 주의 params 는 마지막 인자로만 가능합니다.
    public static void M1(int[] ar, int n) { } // ok
    public static void M2(params int[] ar, int n) { } // error
    public static void M3(int n, params int[] ar) { } // ok
}







}
