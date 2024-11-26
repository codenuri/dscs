class Person
{
	// required : 반드시 초기화 필요 하다.
	// init : 초기화 구문에서만 사용가능. 
	public required string Name{ get; init; }
	public required string Address{ get; set; }
}

class Program 
{
	public static void Main()
	{
//		Person p = new Person(); // error

		Person p = new Person { Name = "kim", Address = "seoul" };

		p.Name = "lee"; // error. 초기화만 가능
		p.Address = "pusan"; // ok
    }
}