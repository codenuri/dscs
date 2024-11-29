using static System.Console;

// index 이야기 (182 ~ )

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // C#8.0 에서 Index 와 Range 가 추가되었습니다.
        Range r1 = new Range(2, 5);  // 2 ~ 4 구간(5포함안됨)
        Range r2 = new Range(2, ^3);

        int[] x1 = arr[r1];
        int[] x2 = arr[r2];

        foreach (int e in x1)
            Console.WriteLine($"{e}, ");
        Console.WriteLine( )
    }
}



