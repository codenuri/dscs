using static System.Console;


class Program
{
    static bool IsMultipleOf(int n) 
    { 
        // 여기서는 Main 메소드의 지역변수에 접근할수 없습니다.
        return n % 2 == 0; 
    }

    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };


        int k = 3; // 사용자가 입력한 값이라고 가정

        // 배열에서 1번째 나오는 k의 배수를 찾고 싶다.
        // => IsMultipleOf 에서 k의 배수를 찾을수 있을까요 ?
        //    (k 는 Main 메소드의 지역변수 )
//      int idx = Array.FindIndex(array, IsMultipleOf);


        // 람다 표현식의 장점.
        // => 자신이 포함된 메소드의 지역변수를 사용할수 있다.

        int idx = Array.FindIndex(array, n => n % k == 0);


        WriteLine($"{idx}");	// 3	
    }
}

// FindIndex(x, IsEven);          // FindIndex 에 "메소드(동작)"만 전달
// FindIndex(x, n => n % k == 0); // FindIndex "동작 + Main의 지역변수 전달"

// Closure : 자신이 포함된 문맥의 지역변수를 캡쳐할수 있는 일급객체
// 일급객체 : 인자로 전달 가능한 객체
//            함수(메소드)도 인자로 전달가능하므로 메소드도 일급객체

// 일반 메소드는 클로져가 아니지만
// 람다 표현식은 클로져가 될수 있습니다.