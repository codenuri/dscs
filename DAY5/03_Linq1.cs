using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 홀수를 출력하는 방법
        // 1. foreach 또는 반복자 사용
        /*
        foreach( var n in arr )
        {
            if ( n % 2 == 1)
                Console.WriteLine(n);
        }
        */
        // 2. Linq 의 Where 사용
        // 핵심 : 반환 타입이 IEnumerable 이므로 c 는 컬렉션 처럼 사용하면됩니다.
        IEnumerable<int> c = arr.Where( x => x % 2 == 1 );

//      IEnumerator<int> e = c.GetEnumerator(); // 이렇게 열거자 꺼내도 되고

        // 컬렉션이므로 foreach에 도 사용가능

        arr[0] = 99;
        /*
        foreach(int e in c )
        {
            Console.WriteLine(e);
        }
        */

        var c2 = arr.Where(x => x % 2 == 1).Where(x => x < 5);

        foreach (int e in c2)
        {
            Console.WriteLine(e);
        }
    }
}
