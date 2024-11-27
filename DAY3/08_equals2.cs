using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);


    public override bool Equals(object? obj)
    {
		Point? other = obj as Point;
		if (other == null) return false;
		return x == other.x && y == other.y;
    }

    // Equals 를 override 하면 GetHashCode 도 같이 override
	// 하는 것이 원칙
	// 5일차 Hash 설명할때 배우게 됩니다.
    public override int GetHashCode()
    {
        return x.GetHashCode() + y.GetHashCode();
    }
}

class Program
{
	public static void Main() 
	{
		Point p1 = new Point(1,2);
		Point p2 = p1;
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// p1, p2 : 동일 객체
		// p3, p4 : 다른 객체, 상태가 동일

		// refeference 타입정리!
		// #1. == 연산자
		// => 동일한 객체인가를 조사
		WriteLine($"{p1 == p2}"); // True
        WriteLine($"{p3 == p4}"); // False

        // #2. object 로 부터 물려받는 Equals() 가상 메소드
		// => object 의 기본 구현은 "==" 사용
		//    결국 "동일 객체" 인가 조사 
		// => 하지만 virtual 메소드 이므로 사용자가 동작을 변경할수 있다
		//    위 구현은 "상태가 동일한가?" 를 조사하는 코드
        WriteLine($"{p1.Equals(p2)}"); // True
        WriteLine($"{p3.Equals(p4)}"); // True
    }
}
