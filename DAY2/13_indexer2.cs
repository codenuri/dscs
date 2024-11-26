class Example
{
    // #1. property 입니다 
	public int Data1
	{
		get => 0;
	}

    // #2. indexer(인덱서) 입니다. e[0] 과 같이 [] 연산자 사용
    public int this[int idx]    		  
	{ 
		get => 0; 
	}
    // #3. 인덱스를 int 가 아닌 다른 타입도 가능. 아래 코드는 string
    public int this[string idx] 		  { get => 0; }

    // #4. 인덱스를 여러개
    public int this[int idx, int idx2]    { get => 0; }

    // #5
    public int this[int idx, string idx2] { get => 0; }
}
class Program
{
    public static void Main()
    {
        Example e = new Example();

        int n0 = e.Data1; // property 사용

        int n1 = e[0];      // #2. 구현 때문에 가능
        
        int n2 = e["A"];    // #3. 

        int n3 = e[0, 1];   // #4. 

        int n4 = e[0, "A"]; // #5
    }
}