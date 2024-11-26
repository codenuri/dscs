class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Animal a = new Cat();

//      Dog d = (Dog)a; // 예외 발생. 실행해 보세요. 

//      Dog d = a as Dog;   // 컴파일 되지만 경고, null 불가 레퍼런스
        Dog? d = a as Dog;  // null 가능 레퍼런스

        if ( d == null )
            Console.WriteLine("실패");
        else
            Console.WriteLine("성공");

        if ( a is Cat c )
        {
            Console.WriteLine("a는 Cat을 가리킵니다.");
            c.Speed = 100;
        }
    }
}