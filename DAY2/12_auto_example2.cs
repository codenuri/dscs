// auto implemented property 로 사용하면
class Person
{
    // 필드
//  public string Name;
//  public string Address;

    // property
    public string Name { get;  };   // get only
    public string Address {  get; set; }    // R/W 가능 

    public Person(string name, string address)
    {
        Name = name;        // get only 라도 생성자는 set 사용가능
        Address = address;
    }
}

class Program
{
    public static void Main()
    {
        Person p = new Person("kim", "jeju");

        // Name 은 초기화 만 가능
        p.Name = "kim"; // error
        p.Nddress = "seoul"; // ok
    }
}