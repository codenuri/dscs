using static System.Console;

// index 이야기 (182 ~ )

class Program
{
    public static void Main()
    {
        int[] arr = { 1,2,3,4,5,6,7,8,9,10 };

        arr[0] = 0; // 1번째 요소
        arr[9] = 0; // 마지막(10번째 요소)

        arr[^1] = 99; //  뒤에서 1번째

        Console.WriteLine(arr[9]); // 99
    }
}
