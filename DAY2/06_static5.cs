class Example
{
    private int data1 = 0;
    private static int data2 = 0;

    // 아래 코드에서 에러를 모두 고르세요
    // static field : 객체가 없어도 처음부터 메모리에 존재, 모든 객체가 공유
    // static method : 객체없이 호출 가능
    public void M1()
    {
        // M1을 호출했다는 것은 
        // "객체를 생성했다는 것. 객체.M1()"

        data1 = 0; // 따라서 이 데이타도 메모리에 있다. ok
        data2 = 0; // ok 
    }
    public static void M2()
    {
        data1 = 0; // error. 객체 없이 호출된 함수에서 instance 멤버 접근 안됨
        data2 = 0; // ok.    static field 는 객체가 없어도 메모리 존재

        // 핵심 : static 은 static 만 접근 가능하다. 
    }
}
class Program
{
    public static Main()
    {
        Example.M2(); // 객체 없이 호출. 
    }
}