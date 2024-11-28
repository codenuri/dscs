class Program
{
    public static void Main()
    {
        // C# 배열의 상속계층은
        // int[] => System.Array => System.Object 입니다.
        int[] x = { 1, 2, 3, 4, 5 };

        Array arr = x; // ok. Array 가 기반 클래스 이므로

        //      x.Add(6); // 1. Add 는 IList 인터페이스에 있는 메소드.
        // 2. 배열은 IList 인터페이스를 구현했습니다.
        // 3. 그런데, 이코드는 에러 입니다.

        IList<int> c = x; // 배열을 IList 인터페이스에 담으면
        c.Add(1);         // Add 호출 가능. 하지만 사용시 예외 발생. 
                          // "Add()" 에서 정의로 이동해 보세요
    }
}
