using static System.Console;




class Program
{

    // 결국 "MyFindIndex" 는 인자로 bool(T) 형태의 메소드를 받게 됩니다.
    // => Func<T, bool> 로 해도 아무 문제 없지만, 
    // => Predicate<T> 가 더 가독성이 좋습니다.

    // 그래서, Action, Func 로 모든 메소드에 대한 delegate로 
    // 사용하지만..
    // 의미가 있는 인자의 경우에는 별도로 만들어진 delegate 가 존재
    // => Predicate<T>, Comparision<T>
    // => Ixx : 라면 인터페이스
    // => delegate는 I가 없습니다.


//    public static int MyFindIndex<T>(T[] arr, Func<T, bool> match) // 이렇게 해도 됩니다.
                                                                   // 아무 문제 없습니다.
    public static int MyFindIndex<T>(T[] arr, Predicate<T> match)
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

    public static bool Foo(double a)
    {
        return a % 3 == 0;
    }

}