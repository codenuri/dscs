// init, required
class Example2
{
    private int data1 = 0;
    private int data2 = 0;

    public int Data1
	{   
		get => data1;
		set => data1 = value;
    }

    // set 대신 init property( C# 9.0)
    // => 객체를 만들때만 사용가능
    // => new Example{ 이위치}
    // => 생성자안.. 
    public int Data2 
	{
		get => data2;
//		set => data2 = value;
		init => data2 = value;
    }

    public Example2()
    {
		Data1 = 0;  // ok
		Data2 = 0;	// ok
    }
}

class Program
{
    public static void Main()
    {
        // property 로 set 하기

        // #1. 객체를 만들때 set
//      Example2 e1 = new Example2(1, 2); // 생성자 인자로 전달
        Example2 e1 = new Example2 { Data1 = 1, Data2 = 2 };

        // #2. 객체 생성후에 필드 처럼 접근
		e1.Data1 = 0;	// ok
		e1.Data2 = 0;	// ok
    }
}
