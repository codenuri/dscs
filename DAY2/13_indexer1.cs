using static System.Console;

// property : set/get 를 자동으로 만드는 문법
// indexer  : 객체를 배열 처럼 [] 연산자 사용가능하게 하는 문법

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
