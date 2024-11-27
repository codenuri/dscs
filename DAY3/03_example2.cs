using static System.Console;

class Shape
{
    private int color = 0;
}

class Rect : Shape
{
    public void Draw() { WriteLine("draw Rect"); }
}
class Circle : Shape
{
    public void Draw() { WriteLine("draw Circle"); }
}

class Program
{
    public static void Main()
    {
        List<Shape> c = new List<Shape>(); 

        while( true )
        {
            int cmd = int.Parse( Console.ReadLine() );

            if      (cmd == 1) c.Add(new Rect());
            else if (cmd == 2) c.Add( new Circle());
            else if (cmd == 9)
            {
                foreach( var s in c)
                    s.Draw();
            }
        }
    }
}
// 위 코드는 어디서 ? 왜?? 에러일까요 ?
// 해결책은 뭘까요 ?


