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