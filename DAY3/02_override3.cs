using static System.Console;

class Animal
{
    public void Cry1() { WriteLine("1. Animal Cry1"); }

    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
    public virtual void Cry3() { WriteLine("1. Animal Cry3"); }
}

class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }
    public override void Cry2() { WriteLine("2. Dog Cry2"); }

    // virtual method 를 new 로 다시 만들수도 있습니다.
    // => 기반 클래스를 override 가 아니라 새롭게 만드는 메소드라는 의미
    // => 많이 사용되지 않는 문법
    // => ad.Cry3() => Animal Cry3 호출
    public new void Cry3() { WriteLine("2. Dog Cry3"); }
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        ad.Cry1();  // 1. Animal Cry1
        ad.Cry2();  // 2. Dog Cry2
        ad.Cry3();  // 1. Animal Cry3
    }
}

