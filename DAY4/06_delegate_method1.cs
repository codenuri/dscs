using static System.Console;

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
    public static void Main()
    {
        Test t = new Test();

        Test.SMethod(1); // static 메소드는 클래스 이름으로 호출
        t.IMethod(1);    // instance 메소드는 객체이름으로 호출

        // #1. delegate 의 Program 클래스의 메소드 가 아닌 
        //     다른 클래스 메소드 등록하기. 
        MyFunc f1 = Test.SMethod;  // 클래스이름.static_method 로 등록
        MyFunc f2 = t.IMethod;     // 객체이름.instance_method 로 등록
                                
                                // 결국 delegate 객체 f1, f2안에는
                                // 메소드주소, 객체 정보등이 모두보관됩니다

        f1(10); // Test.SMethod(10)
        f2(10); // t.IMethod(10)


    }
}
