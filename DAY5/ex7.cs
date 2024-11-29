using System;
using System.Windows;
using System.Windows.Controls;

// Step 7. Layout 클래스
// => 윈도우에 여러개의 컨트롤을 붙이고 싶을때 사용


class MainWindow : Window
{
    public MainWindow()
    {
        StackPanel sp = new StackPanel();

        this.Content = sp; // 윈도우에는 stackpanel 이라는 layout 부착


        // 이제 다양한 자식 컨트롤을 stackpanel 에 넣으면 됩니다.

        Button btn1 = new Button { Content = "확인1" };
        Button btn2 = new Button { Content = "확인2" };
        Button btn3 = new Button { Content = "확인3" };

        btn1.Margin = new Thickness(5, 5, 5, 5);

        sp.Children.Add(btn1);
        sp.Children.Add(btn2);
        sp.Children.Add(btn3);

        // btn1 click 시 메세지 박스 띄워보세요
        btn1.Click += Btn1_Click;
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("button1 click");
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