using static System.Console;

class Program 
{
	public static void Check(string a, string b)
	{
		WriteLine($"a == b      : {a == b}");
		WriteLine($"a.Equals(b) : {a.Equals(b)}");
		WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(a, b)}");
	}
	public static void Main()
	{
		string s1 = "ABCD";
		string s2 = "ABCD";
		string s3 = new string("ABCD");
		string s4 = new string("ABCD");

		// string �� reference type �Դϴ�.
		// �Ʒ� �ڵ� ��� ������ ������
		WriteLine($"{s1 == s2}");
        WriteLine($"{s3 == s4}");


        //      Check(s1, s2); 
        //		Check(s2, s3); 
        //		Check(s3, s4); 
    }
}