using static System.Console;

class Button
{
    public void UserPressButton()
    {
        WriteLine("To Do Something");
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

        btn1.UserPressButton(); 
        btn2.UserPressButton(); 		
    }
}