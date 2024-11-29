using System;
using System.Windows;

// Step 3. event 루프 실행

// 콘솔창 제거하려면
// 프로젝트 설정에서 
// <OutputType>Exe</OutputType> => console 있음
// <OutputType>WinExe</OutputType> => console 없음

class Program
{
    [STAThread]
    public static void Main()
    {
        Window win = new Window();
        win.Show();


        Application app = new Application();
        app.Run(); // 프로그램을 종료하지 말고 event 루프를 실행해 달라.
       
    }
}