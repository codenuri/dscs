// ex2.cs
using System;
using System.Windows;

// Step 2. Window 만들기
// => Main 위에 [STAThread] 추가
// => Window 클래스 객체 생성후 사용. 

class Program
{
    [STAThread]    
    public static void Main()
    {   
        Window win = new Window();
        win.Show();        

        MessageBox.Show("Hello, WPF");
    }
}