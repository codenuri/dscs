using static System.Console;
using System.Collections.Generic; 

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

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1) c.Add(new Rect());
            else if (cmd == 2) c.Add(new Circle());
            else if (cmd == 9)
            {
                foreach (var s in c)
                {
                    // 해결책 #1. 캐스팅
                    // => s는 Shape 타입이지만, 결국 Rect 나 Circle을 가리키게된다.
                    // => 어떤 객체인지 조사해서 캐스팅후 사용하자.

                    if ( s is Rect r ) // if (s is Rect ) Rect r = (Rect)s
                    {
                        r.Draw();
                    }
                    else if ( s is Circle circle)
                    {
                        circle.Draw();
                    }
                }
            }
        }
    }
}



