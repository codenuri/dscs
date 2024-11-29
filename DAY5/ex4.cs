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


        Application app = new Application();
        app.Run(); 

    }
}