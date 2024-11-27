using System;
using System.Reflection;
using static System.Console;

class Program
{
	public static void Main()
	{
		int n = 10;

		PrintHierachy(n);
//		PrintMethods(n);
	}
    public static void PrintMethods(object obj)
    {
        Type t = obj.GetType();

        MethodInfo[] miarr = t.GetMethods();

        foreach (MethodInfo mi in miarr)
        {
            Console.WriteLine($"{mi.Name}");
        }
    }

    public static void PrintHierachy(object? obj)
	{
		if (obj == null)
		{
			Console.WriteLine("PrintHierachy : error. null reference");
			return;
		}
		// 타입정보객체를 구하는 2가지 방법

		Type? t = obj.GetType();			// 객체.GetType()
		Type? objType = typeof(object);		// typeof(타입이름)

		while (true)
		{
			Console.Write($"{t?.FullName}");

			if (t == objType) break;

			Console.Write(" -> ");

			t = t?.BaseType;
		}
		Console.WriteLine();
	}


}







