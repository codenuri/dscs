using static System.Console;

class Point 
{
	private int x = 0;
	private int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);

	public override bool Equals(object? obj)
	{
		if ( obj == null || !(obj is Point) )
		 	return false;

		Point p = (Point)obj;		

    	return x == p.x && y == p.y;
	}

	public override int GetHashCode() 
	{
		return x.GetHashCode() + y.GetHashCode();
	}

	// 연산자 재정의 문법은 5일차 설명.. 
	// 지금은 "==" 를 재정의 할수 있다정도만.. 
	// == 정의시 != 도 같이 해야 합니다.
	public static bool operator==(Point p1, Point p2)
	{
		return p1.x == p2.x && p1.y == p2.y;
	}
	public static bool operator!=(Point p1, Point p2)
	{
		return !( p1 == p2 );
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

		// #1. == 는 기본적으로 "동일객체" 인가에 대한 조사 입니다.
		// => 그런데, "연산자 재정의 문법으로" "==" 의 동작을 변경할수 있습니다.
		WriteLine($"{p3 == p4}");   // True		
                                    // 상태의 동일성 조사

        // #2. 이경우 객체가 동일한가를 조사하려면 아래 처럼 하세요
		// => Point 가 아닌 object 타입에 대해서 == 동작으로 해달라는 것
        WriteLine($"{(object)p3 == (object)p4}"); // False


        WriteLine($"{ReferenceEquals(p3, p4)}");

        // 아래 object.ReferenceEquals 이 우리가 만든
        // "ReferenceEquals" 와 동일
        WriteLine($"{object.ReferenceEquals(p3, p4)}");
    }

	public static bool ReferenceEquals(object? a, object? b)
	{
		return a == b;
	}
}
