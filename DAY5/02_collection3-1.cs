using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

class Program
{
    private const int size = 10_000_000;

    public static void Ex1()
    {
        LinkedList<int> c = new LinkedList<int> ();

        for (int i = 0; i < size; i++)
        {
            c.AddLast(i);
        }
    }

    public static void Ex2()
    {
        List<int> c = new List<int>();

        for (int i = 0; i < size; i++)
        {
            c.Add(i);
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