using static System.Console;


class Program
{
    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        Array.Sort(x);  // 오름 차순 정렬 입니다.

        for(int e in x)
            Write($"{e}, "); // 1, 3, 4, 6, 8

        WriteLine(); // 개행

        // 내림 차순 정렬해 보세요 
        // 핵심 : 정렬시 필요한 2개의 요소의 비교를 어떻게 할지 사용자가 전달

        Array.Sort(x, Foo); // x의 배열에서 2개의 요소를 Foo 에 보내서
                            // 0보다 큰값이 나오면 swap 합니다.
                            
        for(int e in x)
            Write($"{e}, "); // 1, 3, 4, 6, 8

        WriteLine(); // 개행


        //        Comparison<int> c;

    }

    public static int Foo(int a, int b)
    {
        return b.CompareTo(a);
    }

 

}