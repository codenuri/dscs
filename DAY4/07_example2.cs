using static System.Console;

class Program
{
    // Array.FindIndex 를 직접 만들어 봅시다.
    public static int MyFindIndex()
    {

    }
    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };
   
        int ret1 = Array.FindIndex(x, Foo);

        int ret2 = MyFindIndex(x, Foo);

        WriteLine($"{ret2}"); // 2
    }



    public static bool Foo(int a)
    {
        return a % 3 == 0;
    }

}