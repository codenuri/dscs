class Example
{
    private int data1 = 0;
    private static int data2 = 0;

    // 아래 코드에서 에러를 모두 고르세요
    // static field : 객체가 없어도 메모리에 존재, 모든 객체가 공유
    // static method : 객체없이 호출 가능
    public void M1()
    {
        data1 = 0;
        data2 = 0;
    }
    public static void M2()
    {
        data1 = 0;
        data2 = 0;
    }
}
class Program
{
    public static Main()
    {

    }
}