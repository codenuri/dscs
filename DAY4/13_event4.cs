using static System.Console;

delegate void ClickHandler();

class Button
{
    //  public event ClickHandler? Click = null;

    // 위 한줄은(delegate 앞에 event 를 사용하면) 아래 3줄로 변경됩니다.

    private ClickHandler? Click = null;

    //  Click 이 private 이므로 아래 2개의 메소드로만 등록/삭제 해야합니다.
    public void add_ClickHandler(ClickHandler handler)   { Click += handler; }
    public void remove_ClickHandler(ClickHandler handler){ Click -= handler; }

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

        btn.Click += Foo; // btn.add_ClickHandler(Foo)
        btn.Click += Goo; // btn.add_ClickHandler(Goo)
        btn.Click += Hoo;


        btn.UserPressButton();
    }
}