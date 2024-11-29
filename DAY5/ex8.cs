using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

// Step 8. UI 는 C# 코드가 아닌 XML로 !!

class MainWindow : Window
{
    public MainWindow()
    {
        StackPanel sp = null;

        FileStream fs = new FileStream("../../../first.xaml", FileMode.Open);

        // XML 내용을 객체를 생성하고
        // 최상위 객체의 참조를 반환.캐스팅해서 사용하면 됩니다.
        sp = (StackPanel)XamlReader.Load(fs);

        fs.Close(); // 파일 닫기 



        this.Content = sp;
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