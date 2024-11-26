class Example1
{
    private int data1 = 0;
    private int data2 = 0;
    private int data3 = 0;
    private int data4 = 0;
    private int data5 = 0;

    // 문법정리를 위한 예제

    // 1. get/set 일반적인 구현
    public int Data1
	{   
		get { return data1; }	
		set { data1 = value; }
    }

    // 2. expression bodied 를 사용 구현한 것. 내용은 위와 완전히 동일
    public int Data2 
	{
		get => data2;
		set => data2 = value;
    }
    
    // 3. get 만 구현가능. read only
	public int Data3
	{   
		get => data3;   // get_Data() 만 존재. 읽기만 가능. 	
    }

    // 4. set 만 구현, write only
    //    클래스 안에서 내부적으로만 사용(메소드 안에서)하겠다는 것
    public int Data4 
	{
        set => data4 = value; 	
    }

    // 5. private set 
    public int Data5 
	{
        get => data5;
        private set => data5 = value;
    }

    public Example1()
    {
		data5 = 10; // 필드 직접 접근
        Data5 = 10; // set_Data5(5) 로 접근 한것
                    // set_Data5() 안에 값의 유효성 확인이 있다면
                    // => 해당 로직을 적용한것
    }
}

class Program
{
    public static void Main()
    {
//      Example1 e1 = new Example1(); // 정확 한 표기법
        Example1 e1 = new(); //  타입 추론

        e1.Data5 = 10;	// error. private set
    }
}
