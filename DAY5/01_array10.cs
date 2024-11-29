using static System.Console;

// index 이야기 (182 ~ )

class Program
{
    public static void Main()
    {
        int[] arr = { 1,2,3,4,5,6,7,8,9,10 };

        arr[0] = 0; // 1번째 요소
        arr[9] = 0; // 마지막(10번째 요소)

        arr[^1] = 99; //  뒤에서 1번째 ( C#8.0)

        Console.WriteLine(arr[9]); // 99

        // int 타입 : 값만 있습니다
        // System.Index 타입 : 값과 방향이 있습니다.
        int n1 = 3; 

        // Index 객체를 만드는 정확한 표기법
        Index i1 = new Index(3, fromEnd: true); // 뒤에서 3
        Index i2 = new Index(3, fromEnd: false); // 앞에서 3

        // Index 객체는 단축 표기법이 있습니다.
        // 아래 코드가 위코드와 동일
        Index i3 = ^3;
        Index i4 = 3;

        // 배열의 [] 안에는 정수뿐 아니라 Index 객체도 넣을수 있습니다.
        arr[n1] = 0;
        arr[i3] = 0;
        arr[^3] = 0; // 이 표기법이 결국 위 표기법


    }
}



