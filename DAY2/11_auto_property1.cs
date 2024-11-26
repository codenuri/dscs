class Example
{
    // #1. 일반적인 property
    // => 필드를 먼저 만들고
    // => get/set 을 직접 만든 경우
    private int data1 = 0;

    public int Data1
    {
        set => data1 = value;
        get => data1;
    }

    // 아래 한줄이 위 코드와 완전히 동일합니다.
    // => auto implemented property
    // => 컴파일러가 자동으로 필드 까지 생성
    // => set/get 구현은 위와 동일
    public int Data2 { get; set; } = 0;
}



class Program
{
    public static void Main()
    {
        Example e = new Example();
        e.Data1 = 10;

    }
}

// 값의 유효성을 체크하지 않는다면 ????

// public field 로 하면 되는데.. 왜??? auto-implemnted property 를 사용하나요

//p.data2 = 10; // public 필드명
// p.Data2 = 10; // property

// 미래에 값의 유효성 코드를 추가했다고 하면
// => property 의 경우, property 만 변경하면 됩니다.
//    사용하는 코드가 변경될 필요 없습니다.

// => public field 였다면 사용하는 코드가 모두 수정되어야 합니다.

