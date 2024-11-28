using static System.Console;

delegate void ClickHandler();

class Button
{
    // 아래 처럼만들면 등록할때 +=, -=, = 을 모두 사용가능
    //  public ClickHandler? Click = null;


    // 아래 처럼 event 라고 붙이면 +=, -= 만 사용가능    
    public event ClickHandler? Click = null;


    public void UserPressButton()
    {
        Click?.Invoke(); 
    }
}

class Program
{
    public static void Foo() => WriteLine("Foo");
    public static void Goo() => WriteLine("Goo");
    public static void Hoo() => WriteLine("Hoo");

    public static void Main()
    {
        Button btn = new Button();

//      btn.Click = Foo;    // error. 처음 등록도 += 로해야 합니다.
        btn.Click += Foo;
        btn.Click += Goo;
        btn.Click += Hoo;
//      btn.Click = Hoo; // 실수로 += 대신 = 로 했다.
                         // event 였다면 error.


        btn.UserPressButton();        
    }
}