using System;
using System.Windows;
using System.Windows.Controls;

// Step 6. Contents 속성

class MainWindow : Window
{
    public MainWindow()
    {
        // 핵심 : 윈도우는 Contents 속성으로 연결된 객체 한개를
        //        화면에 보여주는 능력이 있습니다.
//      this.Content = "HELLO"; // Title 이 아닌 윈도우 화면 0, 0에 
                                // 문자열이 아닌 그림도 됩니다.
                                // 왠만한것은 다 됩니다.


        Button btn = new Button();
        btn.Content = "확인";

        this.Content = btn;

    }

}



class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow win = new MainWindow();
        win.Show();

        Application app = new Application();
        app.Run();

    }


}