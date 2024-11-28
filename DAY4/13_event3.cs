using static System.Console;

delegate void ClickHandler();

class Button
{
    public ClickHandler? Click = null;

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

        btn.Click = Foo;
        

        btn.UserPressButton();        
    }
}