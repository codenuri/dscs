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


        WriteLine($"{c.Count}, {c.Capacity}");   // ? , ?
    }
}





