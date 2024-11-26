class Person
{
    private int age;

    // 필드처럼 보이지만 {} 가 있고
    // 메소드 처럼 보이기도 하지만 () 가 없습니다.
    public int Age
    {
        get { return age; } 
        set { age = value; }
    }
}

class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Age = 10;
        int n = p.Age;

        Console.WriteLine(n);
 
    }
}
