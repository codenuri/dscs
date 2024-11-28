class Program
{
    public static void Main()
    {
        // 2개의 int 인자를 받아서 합을 반환하는 람다 표현식을 만들어 보세요

        // #1. 정확한 표기법으로 해보세요
        Func<int, int, int> f1 = (int a, int b) => { return a + b; };


        // #2. 가장 간단한 표기법으로 해보세요
        Func<int, int, int> f2 = (a, b) => a + b; // 인자가 2개이므로 ()는 필요
//                             = $1 + $2; // swift 는 이렇게도 가능
//                             = +   // 이런 언어도 있습니다.

        Console.WriteLine($"{f1(1, 2)}"); // 3
        Console.WriteLine($"{f2(1, 2)}"); // 3

//      Foo(1, 2, +); // 연산자도 인자가 될수 있으면 어떨까 ??
    }
}
// int Add(int a, int b) { return a + b;}