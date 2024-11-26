using static System.Console;

// property : set/get 를 자동으로 만드는 문법
// indexer  : 객체를 배열 처럼 [] 연산자 사용가능하게 하는 문법

class Sentence
{
    private string[] words;  // 문자열(단어)의 배열

    public Sentence( string s)
    {
        // 문자열을 단어별로 분리
        words = s.Split();
                // s의 문자열을 단어별로 분리해서 배열로 만들어서 반환
                // new string[] { "Dog", "is", "Animal"}
    }

    public string Text
    {
        // 단어들을 다시 문자열로 조립
        get { return string.Join(" " , words); }
    }

    // indexer 만드는 법
    // 1. property 와 거의 유사
    // 2. 이름 위치에 this[int idx] 넣으세요
    //    "Text" => "this[int idx]" 로 변경
    public string this[int idx]
    {
        get { return words[idx]; }
        set { words[idx] = value; }
    }
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
