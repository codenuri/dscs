using static System.Console;

class Program
{
    // 아래 메소드는  
    // a + b 의 결과는 반환 값으로 알려주고 
    // a - b 의 결과는 out parameter 에 담아 주고 있습니다. 
    public static int AddSub(int a, int b, ref int ret)
    {
        ret = a - b;
        return a + b;
    }

    // out parameter modifier : 초기화되지 않은 변수도 받을수 있다.
    public static int AddSub2(int a, int b, out int ret)
    {
        ret = a - b;
        return a + b;
    }
    public static void Main()
    {
//      int ret1 = 0;  // 초기화된 변수
        int ret1;      // 초기화 되지 않은 변수

//      int ret2 = AddSub(5, 3, ref ret1); // error
        int ret2 = AddSub2(5, 3, out ret1); // ok

        WriteLine($"{ret1}, {ret2}"); // 2, 8

        // out parameter 는 아래 처럼도 사용가능합니다.
        // 인자 위치에서 변수 선언
        int ret3 = AddSub2(5, 3, out int ret4);

        WriteLine($"{ret3}, {ret4}"); // 2, 8
    }
}