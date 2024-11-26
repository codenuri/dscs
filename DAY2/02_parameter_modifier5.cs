using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // int.Parse : 문자열을 정수로 변경
        //			  
        int n1 = int.Parse("10");    // ok. 성공
        int n2 = int.Parse("Hello"); // 실패. 예외 발생


        // int.TryParse : 예외 없이, 성공/실패 반환값으로 전달
        //                결과 정수값은 out parameter 로 전달
        int ret;
        bool b = int.TryParse("Hello", out ret);

        bool b2 = int.TryParse("Hello", out int ret2); // 이렇게도 가능


//      int? ret2 = int.ParseNullable("Hello"); // 이 메소드가 있으면 
                                                // 어땠을까 ?
                                                // 현재는 없습니다.
                                                // 많은 개발자가 요청!~!
    }
}