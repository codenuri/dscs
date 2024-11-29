using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        // 한개 값을 얻는 질의
        int ret = numbers.First();
        Console.WriteLine(ret);

        // 여러개 값을 얻는 질의
        // => 반환값이 IEnumerable 이므로
        // => 메소드 연속호출 가능하고
        // => foreach 에 놓일수 있습니다.
        var result = numbers.Take(3);
        
        foreach (int n in result)
            Console.WriteLine(n);

        //---------------------
        // 순차열 결합
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 3, 4, 5 };

        var arr3 = arr1.Concat(arr2);
        
        foreach (int n in arr3)
            Console.WriteLine(n);
    }
}
