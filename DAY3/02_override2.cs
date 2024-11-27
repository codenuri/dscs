using static System.Console;

class Animal
{
    // non-virtual : static binding 해달라는 의미. 컴파일러가 결정
    //               참조변수의 타입에 따라 호출
    public         void Cry1() { WriteLine("1. Animal Cry1");}

    // virtual method : dynamic binding 해달라는 의미.
    //                  실행시간에 참조변수가 가리키는객체를 실제 조사해서
    //                  객체에 맞는 메소드를 호출해 달라.
    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
}

class Dog : Animal
{
    public new      void Cry1() { WriteLine("2. Dog Cry1");}
    public override void Cry2() { WriteLine("2. Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
		Animal ad = new Dog();

		ad.Cry1();  // 1. Animal Cry1
        ad.Cry2();  // 2. Dog Cry2
    }
}

