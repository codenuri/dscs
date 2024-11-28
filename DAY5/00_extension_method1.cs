// github.com/codenuri/dscs ���� DAY5.zip

using static System.Console;

// extension method( 115p ~ )



// ������ �����ϴ� Ŭ������ �޼ҵ带 �߰��ϰ� �ʹ�.
// #1. ��� ���� ��� 
// => �߰��� �޼ҵ带 ����Ϸ��� "�Ļ� Ŭ�����̸�" �� ����ؾ� �Ѵ�.

// #2. Extension method ���� ���
// => ���� Ŭ���� �̸��� ��� ��밡��

class Example 
{
	public void Foo() => WriteLine("Example Foo");
}

// �Ʒ� �ڵ尡 Example Ŭ������ �޼Ҹ� �߰��� �ڵ�
static class MyExtension
{
	public static void Goo(this Example e)
	{
		Console.WriteLine("Example Goo");
	}
}


class Program
{
	public static void Main()
	{
		Example e = new();
		e.Foo();
		e.Goo(3); // ?
	}
}

