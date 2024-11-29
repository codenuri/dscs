using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// enumerator

class Program
{
    public static void Main()
    {
        List<int> c1 = new List<int>();
        LinkedList<int> c2 = new LinkedList<int>();

        for (int i = 0; i < 5; i++)
        {
            c1.Add(i);
            c2.AddLast(i);
        }
        
        // 각 컬렉션의 열거자의 클래스 이름을 개발자가 알필요 없습니다.

        // #1. var 를 사용하거나
        var e1 = c1.GetEnumerator(); 
        var e2 = c2.GetEnumerator();

        // #2. 인터페이스 이름, IEnumerator<int>로 받으시면 됩니다.
        IEnumerator<int> e3 = c1.GetEnumerator();
        IEnumerator<int> e4 = c2.GetEnumerator();

        // 클래스 이름 알고 싶으면
        WriteLine(e3.GetType().FullName);
        WriteLine(e4.GetType().FullName);
    }
}


