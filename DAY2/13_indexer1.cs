using static System.Console;

// property : set/get �� �ڵ����� ����� ����
// indexer  : ��ü�� �迭 ó�� [] ������ ��밡���ϰ� �ϴ� ����

class Sentence
{
    private string[] words;  // ���ڿ�(�ܾ�)�� �迭

    public Sentence( string s)
    {
        words = s.Split();
                // s�� ���ڿ��� �ܾ�� �и��ؼ� �迭�� ���� ��ȯ
                // new string[] { "Dog", "is", "Animal"}
    }

    public string Text
    {
        get { return string.Join(" " , words); }
    }

}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

//		WriteLine( s[2] ); 	// Animal

//      s[0] = "Cat";

      WriteLine(s.Text);	// Cat is Animal
    }
}
