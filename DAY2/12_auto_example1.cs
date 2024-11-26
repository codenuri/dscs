// public field 는 언제라도 R/W 가능 
class Person
{	
	public string Name;
	public string Address;

	public Person(string name, string address)
	{
		Name = name;
		Address = address;
	}	
}

class Program 
{
	public static void Main()
	{
		Person p = new();

		// public field 는 언제라도 R/W 가능
		p.name    = "kim";
		p.address = "seoul";
	}
}