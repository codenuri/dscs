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
		string s1 = "ABCD"; // string intern pool 안의 객체
		string s2 = "ABCD"; // string intern pool 안의 객체
							// s1, s2 는 동일한 객체 

        string s3 = new string("ABCD"); // pool 객체아님.
		string s4 = new string("ABCD"); // s3, s4는 다른 객체
									

		// string 은 reference type 입니다.
		// 아래 코드 결과 예측해 보세요
		WriteLine($"{s1 == s2}"); // True
        WriteLine($"{s3 == s4}"); // True
								  // string 은 == 연산자를 재정의했습니다.
								  // 그래서 상태의 동일성 조사

		WriteLine($"{object.ReferenceEquals(s1, s2)}"); // True
        WriteLine($"{object.ReferenceEquals(s3, s4)}"); // False


        Check(s1, s2); 
        Check(s2, s3); 
        Check(s3, s4); 
    }
}