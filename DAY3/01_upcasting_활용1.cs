// github.com/codenuri/dscs 에서 DAY3.zip

using static System.Console;

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
// upcasting 활용 #1. 동종을 처리하는 메소드 만들기 
class Program
{
    // 인자로 받은 동물의 나이를 한살 증가하는 메소드
//  public static void NewYear(Dog a) // Dog 객체만 인자로 받을수 있는 메소드
    public static void NewYear(Animal a) // Animal 객체만 받겠다는 의도가 아니라
    {                                    // 동종(모든 동물, Animal 파생 클래스)
        ++(a.Age);                       // 를 인자로 받겠다는 것
    }

    public static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        NewYear(dog);
        NewYear(cat); // ?
    }
}

