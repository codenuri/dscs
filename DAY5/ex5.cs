using System;
using System.Windows;

// Step 5. Window 의 이벤트 처리는 Window 클래스가 처리하자.
// Window 의 파생 클래스 만들기 

class Program
{
    [STAThread]
    public static void Main()
    {
        Window win = new Window();
        win.Show();

        Application app = new Application();
        app.Run();

    }


}