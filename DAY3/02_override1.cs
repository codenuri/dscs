using static System.Console;

// method override ( 104 page ~ )
// C++ 의 가상함수 이야기와 동일한 이야기

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
    // method override : 기반 클래스 메소드를 파생클래스가 다시 구현하는 것
    // C++ : 아래 처럼하면 ok.  C# : 경고 발생(명확히 하기 위해 new)를 표기하라는 것
    // public void Cry() { WriteLine("2. Dog Cry"); }

    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
		Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();	
		d.Cry();

        Animal ad = d; // 실제 객체는 Dog,  참조 타입은 Animal 타입

        ad.Cry(); // Animal.Cry 가 호출될까요 ? Dog.Cry 가 호출될까요 ?
	}
}

