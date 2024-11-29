using static System.Console;

// index 이야기 (182 ~ )

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // C#8.0 에서 Index 와 Range 가 추가되었습니다.
        // Index : 값과 방향 관리
        // Range : 범위(시작 과 끝)
//      Range r1 = new Range(2, 5);  // 3, 4, 5 까지
//      Range r2 = new Range(2, ^3);

        // 단축 표기법
        Range r1 = 2..5;
        Range r2 = 2..^3;

        // 기존 배열에서 구간만 복사한 새로운 배열 생성
        // => Slicing 이라고 합니다.
        int[] x1 = arr[r1]; 
        int[] x2 = arr[r2];
        int[] x3 = arr[2..5]; // 보통 이렇게 사용합니다.

        foreach (int e in x1)
            Console.WriteLine($"{e}, ");
        Console.WriteLine();
    }
}



