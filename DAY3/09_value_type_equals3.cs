using static System.Console;


class Program
{
    public static void Main()
    {
        // 1. value type 은 기본적으로는 == 연산이 안됩니다.
        // 2. int 는 value type 입니다.
        int n1 = 10;
        int n2 = 20;

        WriteLine($"{n1 == n2}"); // 에러 아닙니다.
                                  // 연산자 재정의 문법으로 만들어져
                                  // 있습니다.

    }
}
