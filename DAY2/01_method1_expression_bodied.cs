// github.com/codenuri/dscs 
using static System.Console;

// expression bodied - 71 page
class Program
{
    public static int Square1(int x)
    {
        return x * x;
    }
    // 표현식으로 메소드 구현(expression bodied) 라는 문법
    public static int Square2(int x) => x * x;

    public static void SayHello() => WriteLine("Hello");

    public static void Main()
    {
        int n = Square1(3);
        SayHello();
    }
}





// 1. 출석부 서명해 주세요

// 2. github.com/codenuri/dscs 에서

//    DAY2.zip 받으시면됩니다.

// 3. DAY2.zip 압축 풀고, "Day2.sln" 더블클릭하면
//    vs 에서 열수 있습니다.
