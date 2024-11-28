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
    
    }

 

}