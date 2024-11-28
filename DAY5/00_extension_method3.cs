using static System.Console;

class Program
{
	public static void Main()
	{
		string s = "to be or not to be";

		// C# 표준 string 에는 WordCount() 메소드 없습니다.
		// => 추가해 보세요. 일단 0 반환해 보세요
		int wc = s.WordCount(); 

		WriteLine(wc);
	}
}
