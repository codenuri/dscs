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

class Program
{
    public static void Main()
    {
        Dog[] arr1 = new Dog[10]; // Dog 객체 만 보관 가능한 배열. 
 
        // upcasting 장점(활용) #2. 동종을 저장하는 collection
        // collection : 여러개 객체를 보관하는 도구(배열, List, Hash 등)
        Animal[] arr2 = new Animal[10]; // 모든 동물을 보관 가능

        arr2[0] = new Animal();
        arr2[1] = new Dog();
        arr2[2] = new Cat();

    }
}

