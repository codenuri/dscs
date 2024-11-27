using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;


class Shape
{
    private int color = 0;

    public void SetColor(int c) { color = c; }

    public virtual int GetArea() { return 0; }




    public virtual void Draw() { WriteLine("draw Shape"); }

    // 자신의 복사본을 만드는 가상 메소드는 아주 널리 사용되는 기술입니다.
    public virtual Shape Clone()
    {
        Shape shape = new Shape();
        shape.color = color; // 이외의 모든 멤버를 복사합니다.
        return shape;
    }
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

                // 해결책 #1. 아래 처럼 했다면
                // => OCP 를 만족하지 못하는 좋지 않은 디자인
                /*
                if (c[k] is Rect )
                {
                    Rect r = new Rect();
                    // c[k] 의 모든 속성을 r에 동일하게 복사
                    c.Add(r);
                 }
                */
            }
        }
    }
}


