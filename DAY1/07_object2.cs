using static System.Console;

// System.Object
// => C#�� ��κ��� Ÿ���� System.Object �� ���� ��� �ް� �˴ϴ�.
// => 7���� �޼ҵ带 ���� Ŭ����

// ����� �ڵ�		// �����Ϸ��� ������ �ڵ�
class Car			// class Car  : System.Object
{	
}

class Program
{
	public static void Main()
	{
		Car c = new Car();
		
		

		WriteLine( c.ToString() ); // ok

		object o = c;
	}
}
