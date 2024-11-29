using static System.Console;


// java 는 delegate 문법이 없습니다.
// 그런데, 메소드 인자로 "정책함수"를 받을수 있어야 합니다.
// 그래서 인터페이스 개념을 사용합니다.
// C#도 지원합니다.

interface ICompare<T>
{
    int Compare(T x, T y);
}

// 앞으로 비교정책으로 사용할 모든 객체는 ICompare<T> 를 구현해야 합니다.
// 비교 정책 객체
class MyCompare : ICompare<int>
{
    public int Compare(int x, int y) => y.CompareTo(x);
}



class Program
{
    public static void Swap(ref int x, ref int y)
    {
        int t = x; x = y; y = t;
    }

    // #2. 
    public static void Sort(int[] arr, Comparison<int> cmp)
    {
        var size = arr.Length;

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (cmp(arr[i], arr[j]) > 0)
                    Swap(ref arr[i], ref arr[j]);
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        Sort(arr, (a, b) => b.CompareTo(a));

        foreach (int e in arr)
            Console.WriteLine($"{e}, ");

        Console.WriteLine();
    }
}