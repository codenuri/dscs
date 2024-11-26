using static System.Console;
using System.Collection.Generic; // List<> 사용을 위해

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
        //              C++ 에서는 "container" 라는 용어 사용
        Animal[] arr2 = new Animal[10]; // 모든 동물을 보관 가능

        arr2[0] = new Animal();
        arr2[1] = new Dog();
        arr2[2] = new Cat();

        // 배열 : 크기를 변경할수 없다.
        // List : 크기를 변경할수 있는 배열(동적 배열, 5일차 자세히 설명)
        //        파이썬의 list 와 동일 "c = []"

        List<Animal> c = new List<Animal>();
        c.Add(new Dog());
        c.Add(new Cat());   // 계속 추가 가능. 자동으로 크기 증가 
    }
}

