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

		// string 은 reference type 입니다.
		// 아래 코드 결과 예측해 보세요
		WriteLine($"{s1 == s2}");
        WriteLine($"{s3 == s4}");


        //      Check(s1, s2); 
        //		Check(s2, s3); 
        //		Check(s3, s4); 
    }
}