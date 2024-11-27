using System;
using static System.Console;

// 121page ~

class Program
{
	public static void PrintType(object obj)
	{
		// obj �� ����Ű�� ��ü�� ���� Ÿ���� �˰� �ʹ�.	
		
		Type t = obj.GetType(); // obj �� ����Ű�� ��ü�� ���� 
								// Ÿ�� ������ ������ �޼ҵ�
		WriteLine($"{t.Name} {t.FullName} {t.BaseType}");								

	}

	public static void Main()
	{
		string s = "ABC";
		int    n = 10;
		PrintType(s);
		PrintType(n);
	}
}
