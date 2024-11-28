using static System.Console;

// 이 소스 핵심
// delegate 를 FindIndex() 등의 메소드에 정책 함수 로 보내는 모델이 아니라

// GUI 의 이벤트 처리를 위해서 등록했다가 사용하는 모델 


delegate void ClickHandler();

class Button
{
    // ClickHandler 가 타입(클래스)이름 인것을 헷갈리지 마세요
    public ClickHandler? Click = null;

    public void UserPressButton()
    {
        // Click();
        Click?.Invoke(); // null 이 아닐때만 사용. 
    }
}

class Program
{
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");

    public static void Main()
    {
        Button btn1 = new Button(); 
        Button btn2 = new Button();

        btn1.Click = Foo; // event handler 등록
        btn2.Click = Goo; // event handler 등록

        btn1.UserPressButton(); // Foo 호출
        btn2.UserPressButton(); // Goo 호출
    }
}