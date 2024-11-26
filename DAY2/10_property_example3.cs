using static System.Console;

class Person
{
	private int age;

	// Age 는 "age를 사용하는 Property" 즉, 연결된 필드가 있습니다.

	// swift 에서 이런 property 를 "stored property" 라고 합니다.
	public int Age 
	{
		get => age;
		set => age = value;		
	}

    // swift 에서 아래같은 property 를 "calculation property" 라고 합니다.
    public bool IsAdult
	{
		get => age > 19;
	}


	private string firstName = null!;
	private string lastName = null!;

	// required : 반드시 초기화 되어야 한다.(생성자 또는 new Person{이위치}
	public required string FirstName 
	{
		get => firstName;
		set => firstName = value;
	}
	public required string LastName 
	{
		get => lastName;
		set => lastName = value;
	}

	// 필드는 firstName, lastName 만 있지만
	// 속성은 3개인 예제
    public string FullName
    {
        get => $"{firstName} {lastName}";
        
    }
}


class Program 
{
	public static void Main()
	{
		Person p = new Person{FirstName = "Susan",
							  LastName = "Connor",
							  Age = 20};

//		WriteLine($"{p.FullName}, {p.IsAdult}");
	}
}
