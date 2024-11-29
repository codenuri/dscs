using static System.Console;

class Program
{
    public static void Swap(ref int x, ref int y)
    {
        int t = x; x = y; y = t;
    }
    
    // Sort 의 비교 정책을 변경하는 방법
    // #1. 인자로 delegate 사용 - 어제 배운 방식
    public static void Sort(int[] arr, Comparison<int> cmp)
    {
        var size = arr.Length;

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if ( cmp(arr[i] , arr[j]) > 0 )   
                    Swap(ref arr[i], ref arr[j]);
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        Sort(arr, (a, b) => b.CompareTo(a) );

        foreach (int e in arr)
            Console.WriteLine($"{e}, ");

        Console.WriteLine();
    }
}