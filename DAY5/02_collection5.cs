using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// enumerator

class Program
{
    public static void Main()
    {
        List<int>       c1 = new List<int>();
        LinkedList<int> c2 = new LinkedList<int>();

        for (int i = 0; i < 5; i++)
        {
            c1.Add(i);
            c2.AddLast(i);
        }

        // iterator(반복자) 패턴
        // => 복합객체(컬렉션)의 내부구조가 달라도
        // => 동일한 방법으로 열거하게 하는 방법을 제공하는 패턴
        // C++, java, python : iterator 용어 사용
        // C# : enumerator

        // #1. 대부분의 컬렉션에는 enumerator 를 꺼내는 메소드가 있습니다
        var e1 = c1.GetEnumerator(); // List 의 enumerator
        var e2 = c2.GetEnumerator(); // LinkedList 의 enumerator

        // #2. Enumerator 의 사용법은 동일합니다.
        // => e1, e2 는 다른 타입이지만 같은 방법사용

        while( e1.MoveNext() )
            Console.WriteLine( e1.Current );


        while (e2.MoveNext())
            Console.WriteLine(e2.Current);
    }
}






