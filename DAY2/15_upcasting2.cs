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

        Dog d = (Dog)a; // 예외 발생. 실행해 보세요. 

    }
}