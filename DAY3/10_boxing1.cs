using System.Net.Http.Headers;
using static System.Console;

// 137page ~

class CPoint 
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;
	public CPoint(int a, int b) => (X, Y) = (a, b);
}
struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main()
	{
		// #1. Reference Type 은 객체를 힙에 만들고
		// #2. 참조 변수가 스택에 생성되서 힙에 있는 객체를 가리키게 됩니다
		// #3. 참조 변수가 파괴되고 특정조건을 만족하면 힙에 객체는 자동파괴됩니다.
		//     (garbage collector)
		CPoint p1 = new CPoint(1, 2);

		// C++ 처럼 delete 하지 않아도 됨.



		// 아래 6줄 실행시 메모리 상태를 생각해 봅시다.
		CPoint cp1 = new CPoint(1, 1);
		object co = cp1;
		CPoint cp2 = (CPoint)co;

        SPoint sp1 = new SPoint(1, 1);
        object so = sp1;
        SPoint sp2 = (SPoint)so;
    }
}