using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // 자신의 static method 호출
        Program.SMethod(1); // 클래스이름.메소드이름() 이 원칙
        SMethod(1);         // 하지만 자신과 같은 클래스 멤버이므로
                            // 클래스 이름 생략가능.

        // delegate 에 다른 클래스 메소드가 아닌  자신의 메소드 등록하기
        // #1. 자신의 static method
        MyFunc f1 = Program.SMethod; // 정확한 표기법
        MyFunc f2 = SMethod;         // 자신의 멤버 이므로 클래스이름 생략가능

        // #2. 자신의 instance method
        // => 현재는 Main 메소드 내부의 코드인데, 
        // => Main 메소드는 static Method 이므로
        // => 객체가 없이 호출되었을것이므로... 아래 코드가 에러

//      MyFunc f3 = IMethod;    // error. Program 객체를 만든적이 없다

        Program pg = new Program();
        MyFunc f3 = pg.IMethod; // ok 

        pg.InstanceMethod();
    }

	public void InstanceMethod()
	{
        MyFunc f4 = IMethod;      // ok. 이 표현은 아래와 동일
        MyFunc f5 = this.IMethod; // this : 자신을 가리키는 키워드

        // static method 도 아래 처럼 가능
        MyFunc f6 = Program.SMethod;
        MyFunc f7 = SMethod
	}
}
// 결론 자신의 메소드를 delegate 에 등록할때
// static Method 안에서 작업할때 (객체가 없는 상태)
// => 객체를 만들어야만 인스턴스 메소드 등록가능

// instance Method 안에서 작업할때 (객체가 이미 있는 상태)
// => 인스턴스 메소드 바로 등록가능
