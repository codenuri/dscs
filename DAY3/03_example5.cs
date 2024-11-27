using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;


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


    public override  Shape Clone()
    {
        Rect r = new Rect();
        // 자신의 모든 멤버를 r에 복사
        return r;
    }
}
class Circle : Shape
{
    public override void Draw() { WriteLine("draw Circle"); }

    public override Shape Clone()
    {
        Circle c = new Circle();
        // 자신의 모든 멤버를 r에 복사
        return c;
    }
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

                // 해결책 #2. k번째 도형이 어떤 도형인지 조사할 필요 없다.
                //          단지, 복사본 만들어 달라고 요청하면된다.
                //          java 에서는 이것을 "don't ask do it" 이라고합니다.

                c.Add(c[k-1].Clone()); // 다형성!!! OCP 만족
            }
        }
    }
}

// 많은 객체지향 프로그램이 위와 같은 Clone()을 만들어 사용합니다.
// 그래서 이기법에 이름이 있습니다
// "prototype" 이라는 이름을 가진 디자인 패턴 입니다.
// => 이런 이름이 23개가 있습니다.
// => 이걸 배우는 과정이 디자인 패턴 과정. 

// 리팩토링에서 사용되는 용어 입니다. 이해해 보세요

// "replace conditional with polymorphism"
// "제어문(if, switch) 을 다형성(가상메소드)으로 변경해라"

