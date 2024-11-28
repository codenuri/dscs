using static System.Console;


class Program
{
    static bool IsMultipleOf(int n) { return n % 2 == 0; }

    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };


        int k = 3; // 사용자가 입력한 값이라고 가정

        // 배열에서 1번째 나오는 k의 배수를 찾고 싶다.
        // => IsMultipleOf 에서 k의 배수를 찾을수 있을까요 ?
        int idx = Array.FindIndex(array, IsMultipleOf);




        int idx = Array.FindIndex(array, n => n % 2 == 0);


        WriteLine($"{idx}");	// 3	
    }
}
