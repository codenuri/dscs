using static System.Console;


// java 는 delegate 문법이 없습니다.
// 그런데, 메소드 인자로 "정책함수"를 받을수 있어야 합니다.
// 그래서 인터페이스 개념을 사용합니다.
// C#도 지원합니다.
/*
// 이미 C# 표준에 아래 인터페이스 있습니다. 
interface IComparer<T>
{
    int Compare(T x, T y);
}
*/

// 앞으로 비교정책으로 사용할 모든 객체는 ICompare<T> 를 구현해야 합니다.
// 비교 정책 객체
class MyCompare : IComparer<int>
{
    public int Compare(int x, int y) => y.CompareTo(x);
}

class Program
{
    public static void Swap(ref int x, ref int y)
    {
        
        int t = x; x = y; y = t;
    }

    // #2. 인자로 메소드가 아닌 객체가 받는 방식
    // => java style 인데, C# 도 지원하는 방식
    public static void Sort(int[] arr, IComparer<int> cmp)
    {
        var size = arr.Length;

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (cmp.Compare(arr[i], arr[j]) > 0)
                    Swap(ref arr[i], ref arr[j]);
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        Sort(arr, new MyCompare() );

        foreach (int e in arr)
            Console.WriteLine($"{e}, ");
        Console.WriteLine();

   
    }
}

// 핵심 정리
// Array.Sort() 등을 사용할때 비교 정책을 변경하고 싶을때가 있습니다.
// 2번째 인자로 비교정책을 보내면 됩니다.
// 비교정책을 보내는 방법 

// 방법 #1. 람다표현식등의 메소드를 전달하는 방식 - delegate로 받고 있습니다.
// 방법 #2. 약속된 인터페이스(IComparer<T>) 를 구현한 객체를 보내는 방식

// Comparison<T> : delegate
// IComparer<T>  : interface