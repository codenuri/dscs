using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Select 만들기.

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var result  = arr.MySelect(n => n * 2);

        foreach (int n in result)
            Console.WriteLine(n);
    }
}

// 배열에 MySelect 함수를 추가합니다.
static class ArrayExtension
{
    public static IEnumerable<int> MySelect( this Array ar, Func<int, int> f)
    {


        foreach (int elem in ar)
            yield return f(elem); // 코루틴 개념. 
    }   
}

// 정확한 원리르 알고 싶다면
// 1. C# 의 코루틴을 공부하세요
// 2. extension method 문법을 알아야 합니다.
// 3. 위 MySelect 분석하면 됩니다.