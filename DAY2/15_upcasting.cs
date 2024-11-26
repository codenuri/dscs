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
        Dog dog = new Dog(); // ok

//      string s = new Dog(); // error. 

        // 핵심 #1. 기반 클래스 참조로 파생 클래스객체를 가리킬수 있다.
        // => "upcasting" 이라는 개념
        // => 가능한 이유를 메모리 그림을 생각해 보세요
        Animal a = new Dog(); // ok
    }
}