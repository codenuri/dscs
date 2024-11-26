class Example
{
    private int data1 = 0;
	private int data2 = 0; // 필드를 명시적으로 생성

	// set only, get only 모두 가능
	// => 내부 멤소드에서는 필드명으로 접근가능하므로(R/W가능)
	public int Data1 { set => data1 = value; }	// set_Data1(value)
    public int Data2 { get => data2;  }			// get_Data2()
	

	// auto implmented 의 경우는 사용자가 만든 필드는 없고 컴파일러가 생성
	// => 사용자는 필드명을 알수 없음. 
///	public int Data3 { set; } = 0; // error. set_Data3(3) 처럼 변경시
									// 변경된 데이타를 접근할(Read)방법이 없다.
									// 메소드 안에서도!! 필드이름 모름. 

	public int Data4 { get; } = 0;	// ok. 꺼내기만 가능하고 변경안됨.
									// 단, 생성자에서는 set 가능


	public Example(int a, int b)
	{
		Data4 = a; // get only 지만 생성자에서는 이 코드가 가능.
	}
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example(1, 1);
		
		e.Data2 = 10;	// error
		e.Data4 = 10;	// error. 

    }
}
