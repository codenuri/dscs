using static System.Console;

class Program
{
	public static void Main()
	{
		string s = "to be or not to be";

		// C# ǥ�� string ���� WordCount() �޼ҵ� �����ϴ�.
		// => �߰��� ������. �ϴ� 0 ��ȯ�� ������
		int wc = s.WordCount(); 

		WriteLine(wc);
	}
}
