using static System.Console;

// Value Type vs Reference Type - 31page ~ 
// => C# 언어의 핵심

// C#의 모든 타입은 "struct" 또는 "class" 문법으로 만들어진 타입입니다.
// struct : value type
// class  : reference type


class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// 아래 코드 실행시 메모리 그림이 36 page 입니다.
		CPoint cp = new CPoint(0, 0);
		SPoint sp = new SPoint(0, 0);	
	}
}

// C/C++
// => 메모리 위치를 타입 사용자가 결정. 
// Point pt; // pt는 스택에 놓이게 됩니다.
// Point* p = new Point; // 힙에 생성


// C#, Java, Swift
// => 메모리 위치를 "타입 설계자" 가 결정
// => 타입의 크기 등의 정보는 설계자가 알수 있다.

// struct : stack 에 생성, value type
// class  : heap 에 생성, stack 에서 참조(포인터)가 가리키게됨. reference type