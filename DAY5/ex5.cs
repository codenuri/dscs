using System;
using System.Windows;

// Step 5. Window 의 이벤트 처리는 Window 클래스가 처리하자.
// Window 의 파생 클래스 만들기 

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

        this.MouseLeftButtonDown += LeftDown;
    }

    private void LeftDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("Click");
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