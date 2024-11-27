using static System.Console;
using System.Collections.Generic;

// 핵심 #1. 모든 도형(파생 클래스)의 공통의 특징이 있다면
//         반드시 기반 클래스에도 제공되어야 한다.
//         그래야, 기반 클래스 참조로 해당 특징을 사용할수 있다.
//         문법적 규칙이 아닌 디자인 규칙

// 핵심 #2. 기반 클래스 메소드 중에 파생 클래스가 override 하게 되는 것은
//          반드시 virtual 로 해야 한다.
//          파생 클래스에서는 "override" 로 재정의
class Shape
{
    private int color = 0;

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
        }
    }
}


