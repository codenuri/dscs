using static System.Console;

// method override ( 104 page ~ )
// C++ �� �����Լ� �̾߱�� ������ �̾߱�

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
    // method override : ��� Ŭ���� �޼ҵ带 �Ļ�Ŭ������ �ٽ� �����ϴ� ��
    // C++ : �Ʒ� ó���ϸ� ok.  C# : ��� �߻�(��Ȯ�� �ϱ� ���� new)�� ǥ���϶�� ��
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

        Animal ad = d; // ���� ��ü�� Dog,  ���� Ÿ���� Animal Ÿ��

        ad.Cry(); // Animal.Cry �� ȣ��ɱ�� ? Dog.Cry �� ȣ��ɱ�� ?
	}
}

