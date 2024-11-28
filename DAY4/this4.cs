delegate void MyFunc(int arg);

// delegate 에 메소드를 등록할때
// static   메소드는 "클래스이름.메소드이름" 으로 등록
// instance 메소드는 "객체이름.메소드이름" 으로

class Example
{
    public        void IM(int arg) { }
    public static void SM(int arg) { }

    public void InstanceMethod() // void InstanceMethod(Example this)
    {
        // 아래 2줄이 정확한 표기법
        MyFunc f1 = Example.SM;
        MyFunc f2 = this.IM;

        // 그런데, SM, IM 모두 자신의 멤버 이므로 아래 처럼도 가능
        MyFunc f1 = SM;
        MyFunc f2 = IM;

    }

    // static Method : 객체없이 "Example.StaticMethod"
    public static void StaticMethod() // void StaticMethod()
    {
        MyFunc f1 = Example.SM;
//      MyFunc f2 = this.IM;    // error

        MyFunc f1 = SM;
//      MyFunc f2 = IM;         // error

        // 여기서 IM 을 사용하거나, delegate 에 등록하려면
        // 결국 자신의 객체를 만드는 방법밖에 없다.
        Example e2 = new Example();
        MyFunc f3 = e2.IM;  // 오직 이 방법만 가능

    }
}

class Program
{
    public static void Main()
    {
        Example e = new Example();
        
        e.InstanceMethod(); // InstanceMethod(e)


    }
}