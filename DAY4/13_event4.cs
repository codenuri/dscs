using static System.Console;

delegate void ClickHandler();

class Button
{
    //  public event ClickHandler? Click = null;

    // 위 한줄은(delegate 앞에 event 를 사용하면) 아래 3줄로 변경됩니다.

    private ClickHandler? Click = null;

    //  Click 이 private 이므로 아래 2개의 메소드로만 등록/삭제 해야합니다.
    public void add_Click(ClickHandler handler)   { Click += handler; }
    public void remove_Click(ClickHandler handler){ Click -= handler; }

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

        btn.Click += Foo; // btn.add_Click(Foo)
        btn.Click += Goo; // btn.add_Click(Goo)
        btn.Click += Hoo; // 지금 왼쪽 코드는 에러.


        btn.UserPressButton();
    }
}

// event3 빌드해서 에러 없는지 확인하고 Day4.dll 만드세요
// ILDASM 에서 열어 보세요
