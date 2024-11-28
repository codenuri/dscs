using static System.Console;


delegate bool MyFunc(int a);


class Program
{
    // Array.FindIndex �� ���� ����� ���ô�.

    public static int MyFindIndex(int[] arr, MyFunc match  )
    {
        // ���⼭ match �� ����ڰ� ������ �޼ҵ�(ȣ������)�� ��� ��ü

        for( int i = 0; i < arr.Length; i++)
        {
            if (match(arr[i]) == true)
                return i;
        }
        return -1;
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