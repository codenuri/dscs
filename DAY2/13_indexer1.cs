using static System.Console;

// property : set/get �� �ڵ����� ����� ����
// indexer  : ��ü�� �迭 ó�� [] ������ ��밡���ϰ� �ϴ� ����

class Sentence
{
    
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

		WriteLine( s[2] ); 	// Animal

        s[0] = "Cat";

        WriteLine(s.Text);	// Cat is Animal
    }
}
