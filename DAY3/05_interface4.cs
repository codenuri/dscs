using static System.Console;

// C++언어 : 복잡하기로 유명하고, 문법이 많습니다

// java(1994년발표) : C++의 복잡함은 template, 연산자 재정의, 포인터등이 있기 때문이다.
//        java 는 이런 문법 사용하지 않겠다..

// C# 1.0(2002년경) : template 지원 안됨. 그래서 아래처럼 만들수 밖에 없었다.
/*
interface IComparable
{
    int CompareTo(object obj);  
}
*/

// C# 2.0 : template(generic)문법이 도입됩니다.
//          사용자가 타입을 지정하는 문법(내일 자세한 문법 배웁니다.)
// 그래서 C# 2.0 부터 아래 인터페이스 도입됩니다.
/*
interface IComparable<T>
{
    int CompareTo(T obj);
}
*/


class Label : IComparable<Label>
{
    private string title;

    public Label(string s) => title = s;

     public int CompareTo(Label? other) 
    {                                 
        return title.CompareTo(other?.title);
    }
}

class Program
{
    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = new Label("BAD");

        int ret1 = d1.CompareTo(d2); // ok. d2 는 Label 타입

        // C#의 대부분의 타입은 object 로 부터 파생 되므로
        // 대부분의 객체는 object 로 가리킬수 있습니다.
        object obj = d2;

        int ret2 = d1.CompareTo(obj); // 되는게 좋으세요 ?
                                      // 안되는 게 좋으세요 ?
    }


}

