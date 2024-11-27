using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;


class Shape
{
    private int color = 0;

    public void SetColor(int c) { color = c; }

    public virtual int GetArea() { return 0; }




    public virtual void Draw() { WriteLine("draw Shape"); }
}
class Rect : Shape
{
    public override void Draw() { WriteLine("draw Rect"); }
}
class Circle : Shape
{
    public override void Draw() { WriteLine("draw Circle"); }
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
                    s.Draw(); 
                }
            }

            else if ( cmd == 8)
            {
                Write("몇번째 만든 도형을 복제 할까요 >> ");

                int k = int.Parse(Console.ReadLine());

                // k번째 만든 도형의 복사본을 만들어서 collection c 끝에 추가
                // => 어떻게 해야 할까요 ?
                // => k번째 도형은 뭘까요 ?
            }
        }
    }
}


