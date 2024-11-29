using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

// 후방 삽입 : List 가 아주 빠릅니다.
// 전방(중간) 삽입 : List 는 느립니다.(메모리 복사 발생)

class Program
{
    private const int size = 100_000;

    public static void Ex1()
    {
        LinkedList<int> c = new LinkedList<int> ();

        for (int i = 0; i < size; i++)
        {
//          c.AddLast(i);
            c.AddFirst (i);
        }
    }

    public static void Ex2()
    {
        List<int> c = new List<int>();

        for (int i = 0; i < size; i++)
        {
            //          c.Add(i);
            c.Insert(0, i);
        }
    }

    public static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        Ex1();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);

        sw.Restart();
        Ex2();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}