using System;

// in(C#7.2), ref readonly(C#12.0)

class Program
{
    // call by value : 복사본 생성
    // 보통 value type 은 크기가 작아서 읽기만 한다면 복사본 나쁘지 않습니다.
    // 그런데, 크기가 큰 value type 이 있을수도 있습니다.
    // 이경우, call by value 보다 call by reference 가 좋을수 있습니다.

    //  public static void M1(int n) // 복사본
    //  public static void M1(ref int n) // 복사본 아님, 하지만 원본이 수정될 가능서 있음
    public static void M1(in int n)      // 읽기 전용 reference(C#7.2)
    {                                    // const int&
        int a = n;
//      n = 10; // error. in 은 읽기만 가능한 reference 
    }

    // C# 12.0 의 readonly ref 문법
    // => in 과 거의 동일한데
    // => rvalue 를 받을수 없다는 특징이 있습니다.
    public static void M2(  ref readonly int n)
    {
        int a = n;  
    }

    public static void Main()
    {
        int x = 0;
        M1(in x);   // in 을 표기해도 되고
        M1(x);      // 생략해도 됩니다.
        M1(3);      // 변수(lvalue)가 아닌 literal(rvalue) 전달 ?
                    // ok. 메모리를 임시로 할당(임시객체)하고 3으로 초기화하고
                    // 주소 전달 합니다.( C++ 특징을 그대로 도입)

        
        M2(ref x);  // 이렇게 전달
        M2(in x);   // in 사용도 가능
        M2(x);      // ref, int 생략 가능하지만, 경고 발생. (87 page)
        M2(3);      // error
    }
}