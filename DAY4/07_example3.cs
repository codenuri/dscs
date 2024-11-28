using static System.Console;



// generic delegate
delegate bool MyPredicate<T>(T a);

class Program
{

    public static int MyFindIndex<T>(T[] arr, MyPredicate<T> match)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (match(arr[i]) == true)
                return i;
        }

        return -1;
    }



    public static void Main()
    {
        double[] x = { 1, 8, 6, 4, 3 };

        int ret1 = Array.FindIndex(x, Foo);

        int ret2 = MyFindIndex(x, Foo);

        WriteLine($"{ret2}"); // 2
    }

    public static bool Foo(int a)
    {
        return a % 3 == 0;
    }

}