using static System.Console;

// 112 page ~ 


class Program 
{
	public static void Main()
	{
		int n1 = 10;
		int n2 = 20;

		string s1 = "AAA";
		string s2 = "BBB";

		// ũ�⸦ ���ϴ� ���. 
		// #1. �� ������(<, >,...) ���
		// => ���� Ÿ��(����, �Ǽ�) �� ����.
		bool b1 = n1 < n2;
//      bool b2 = s1 < s2;  // error

		// #2. CompareTo �޼ҵ� ���
		// => ũ�� �񱳰� ������ ��κ��� Ÿ�Կ��� ����
		int ret1 = n1.CompareTo(n2); // ok
        int ret2 = s1.CompareTo(s2); // ok.
									 // s1�� ũ�� ����� ���
									 // s2�� ũ�� ����� ����
									 // ������ 0
									 // C��� strcmp �� ����!

		M1(n1);
		M1(s1);
    }

	// �Ʒ� �޼ҵ�� CompareTo �޼ҵ尡 �ִ� Ÿ���� ��� ��ü�� ���ڷ� 
	// ������ �ֽ��ϴ�.
	public static void M1(IComparable ic)
	{
	}

}
