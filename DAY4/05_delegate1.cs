using System;
using static System.Console;

// delegate ( 156 ~ )

class Program
{
	public static void Main()
	{
		// ? ��ġ�� �� Ÿ���� ������ ������
		int    n = 10;
		double d = 3.4;
		string s = "abc";

		? f = Foo;  // ? �� �޼ҵ带 ��� Ÿ��
					// ��Ȯ���� "�޼ҵ��� ȣ�� ����"�� ��� Ÿ��
					// => "delegate"
					// => C/C++ �� �Լ� ������
	}

	public static void Foo(int arg) 
		=> WriteLine($"Foo : {arg}");
}
