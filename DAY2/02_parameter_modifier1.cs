using static System.Console;

// 79 page
class Program
{
	// 아래 메소드는 복사본 x 를 생성합니다.
	// => call by value(C와 동일 )
	// => 79 page 위 그림
	
	public static void Inc1(int x)
	{
		++x;	// 복사본 증가
	}

	// ref modifier
	// => 복사본이 아닌 참조로 받아달라는 의미
    public static void Inc2(ref int x)
    {
        ++x;    
    }
    public static void Main()
	{
		int n = 0;
		Inc1(n);
		WriteLine(n); // 0

        Inc2(ref n);	// 참조로 전달해 달라.
        
        WriteLine(n);	// 1

    }
}