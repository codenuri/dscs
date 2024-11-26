using static System.Console;

// property : set/get 를 자동으로 만드는 문법
// indexer  : 객체를 배열 처럼 [] 연산자 사용가능하게 하는 문법

class Sentence
{
    private string[] words;  // 문자열(단어)의 배열

    public Sentence( string s)
    {
        words = s.Split();
                // s의 문자열을 단어별로 분리해서 배열로 만들어서 반환
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
