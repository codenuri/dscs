using static System.Console;

class CPoint
{
	public int x;
	public int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	public int x;
	public int y;
	public SPoint(int a, int b) { x = a; y = b; }	
}

class Program 
{
	public static void Main()
	{
		// 38 page 그림 참고
		CPoint cp1; // 객체 생성안됨. 참조(포인터)변수만 만든것

		SPoint sp1;
		SPoint sp2 = new SPoint(1, 1);
		
		// cp1 은 객체가 없음.
		int a = cp1.x;	// error
		cp1.x = 2;		// error

		// sp1은 초기화 안된 객체
		int b = sp1.x;	// error . Read!!
		sp1.x = 2;		// ok. Write
		int c = sp1.x;	// ok. Write 후에는 Read 가능

		// sp2는 초기화된 객체(생성자 호출됨.)
		int d = sp2.x;	// ok
		sp2.x = 2;		// ok

	}
}
