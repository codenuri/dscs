using System;
using System.Windows;

// Step 4. Property 와 event

class Program
{
    [STAThread]
    public static void Main()
    {
        Window win = new Window();
        win.Show();

        // #1. Property 설정
        win.Title = "Hello, WPF";
        win.Width = 500;
        win.Height = 500;

        // #2. 이벤트 처리
        // btn.Click += Foo; // 어제 수업 delegate & event 생각해 보세요

        win.MouseLeftButtonDown += Win_MouseLeftButtonDown;



        Application app = new Application();
        app.Run(); 

    }

    private static void Win_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("Window Click");
    }
}