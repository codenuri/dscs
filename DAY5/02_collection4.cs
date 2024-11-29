using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// list 캐패시터

class Program
{
    public static void Main()
    {
        List<int> c = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        // Count    :  요소의 갯수
        // Capacity :  실제 사용하는 메모리의 크기
        WriteLine($"{c.Count}, {c.Capacity}");    // 8, 8

        c.RemoveAt(3);  // 메모리 자체가 줄지 않습니다

        WriteLine($"{c.Count}, {c.Capacity}");   // 7, 8


        c.Add(1); // Count < Capacity 이므로 이연산은
                  // 메모리 재할당 없습니다
                  // 아주 빠르게 동작합니다.

        WriteLine($"{c.Count}, {c.Capacity}");   // 8, 8


        c.Add(1); // Count == Capacity 이므로 이연산은
                  // 메모리 재할당이 있습니다.
                  // 비싼연산입니다.(느리다는 의미)

                  // 메모리(capacity) 할당할때 기존 크기 * 2 가됩니다.
                  // 그래서, 이후에 호출되는 Add 는 성능이 아주좋게 됩니다
                  // C++, Java, C#, Python 모두 동일합니다.

        WriteLine($"{c.Count}, {c.Capacity}");   // 9 , 16

        c.TrimExcess(); // 여분의 메모리 필요 없다.
                        // 이순간 9개 메모리 재할당후
                        // 기존 메모리 내용 => 9개 메모리 복사후
                        // 기존 메모리 제거

        WriteLine($"{c.Count}, {c.Capacity}"); // 9, 9

        c.Clear(); // count 만 0으로 메모리는 계속 9

        WriteLine($"{c.Count}, {c.Capacity}"); // 0, 9

        c.TrimExcess();
        WriteLine($"{c.Count}, {c.Capacity}"); // 0, 0
    }
}
// 파이썬 : s = [1,2,3]   =>실제로는 4개 할당 됩니다.
//          s.append(4)  =>메모리할당없고
//          s.append(5)  =>8개로 할당, 이후 부족하는 8의 배수로 사용하다가
//                         특정갯수이상으면 16, 32, 64의 배수 
//                         버전마다 달라집니다.




