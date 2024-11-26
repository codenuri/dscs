// params - 77page

class Program
{
    public static void Main()
    {
        // #1. 배열을 선언하는 다양한 방법 알아 두세요
        int[] x1 = new int[3];      // 0, 0, 0 으로 초기화
        int[] x2 = new int[3] { 1, 2, 3 };
        int[] x3 = new int[]  { 1, 2, 3 };
        int[] x4 = { 1, 2, 3 }; // 단축 표기법 제공
                                // 일반 적인 코딩 관례

        // #2. 메소드 인자로 배열 보내기
        M1(new int[] { 1, 2, 3 }); // ok

        // M1( {1,2,3} );       // error.  메소드 인자로는 이 표기법 안됨.
                                // 그래서 위 코드 처럼만 사용해야 합니다.

        // params 로 받으면 아래 처럼 전달가능합니다
        M2(new int[] { 1, 2, 3 }); // ok

        M2( 1, 2, 3 ); // 1, 2, 3 => new int[]{1,2,3} 으로 변경한것
        M2( 1, 2); // C 언어의 가변인자 처럼 보이지만
                    // 원리는 new int[2]{1,2} 처럼 배열로 만들어전달
    }

    // params : 배열을 인자로 받지만
    //          호출시, 다양한 표기법으로 사용가능하게.
    public static void M2(params int[] ar) { }


    // 메소드 인자로 int 타입의 값을 가변으로 받고 싶다.
    // => 배열로 받으면 됩니다.
    public static void M1(int[] ar) { }




}
