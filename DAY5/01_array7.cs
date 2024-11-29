using static System.Console;

class Program
{
    public static void Swap(ref int x, ref int y)
    {
        int t = x; x = y; y = t;       
    }
    // Sort 를 생각해 봅시다
    // => 아래 구현은 selection 입니다. 실제 C#은 퀵으로 구현
    public static void Sort(int[] arr)
    {
        var size = arr.Length;

        for ( int i = 0; i < size - 1; i++)
        {
            for (int j = i+1; j < size; j++)
            {
                if (arr[i] > arr[j])    // 이렇게 하면 항상 오름차순 정렬입니다.
                    Swap(ref arr[i], ref arr[j]);
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
        Sort(arr);

        foreach(int e in arr)
            Console.WriteLine($"{e}, ");

        Console.WriteLine(); 
    }
}