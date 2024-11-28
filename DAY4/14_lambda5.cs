class Program
{
    public static void Main()
    {
        // 2개의 int 인자를 받아서 합을 반환하는 람다 표현식을 만들어 보세요

        // #1. 정확한 표기법으로 해보세요
        Func<int, int, int> f1 = ?;


        // #2. 가장 간단한 표기법으로 해보세요
        Func<int, int, int> f2 = ?;

        Console.WriteLine($"{f1(1, 2)}"); // 3
        Console.WriteLine($"{f2(1, 2)}"); // 3
    }
}