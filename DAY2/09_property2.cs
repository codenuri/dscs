class Person
{
    private int age;

    // 필드처럼 보이지만 {} 가 있고
    // 메소드 처럼 보이기도 하지만 () 가 없습니다.
    public int Age
    {
        get { return age; } 
        set { if( value > 0 && value < 150) age = value; }
    }
}
class Program
{
    public static void Main()
    {
        Person p = new Person();

        // property 는 사용시 public 필드처럼 사용합니다.
        // => 메소드 처럼 만들고, 필드 처럼 사용하게 하는 문법
        p.Age = 10;
        int n = p.Age;

        Console.WriteLine(n);
 
    }
}
