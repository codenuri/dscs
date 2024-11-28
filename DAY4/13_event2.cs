using static System.Console;


delegate void ClickHandler();


class Button
{
    // ClickHandler 가 타입(클래스)이름 인것을 헷갈리지 마세요
    public ClickHandler Click = null;

    public void UserPressButton()
    {
        Click();
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