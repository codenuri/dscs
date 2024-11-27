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


    // 아래 메소드는 virtual 로 할까요 ? non-virtual 로할까요 ?
    // override 할 이유 없습니다. "non- virtual"
    public void SetColor(int c) { color = c; }


    // 모든 도형의 면적구하는 방식은 다르다.
    // 도형마다 override 해야 한다. virtual 사용
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
                    s.Draw(); // 다형성(Polymorphism)
                              // => 동일한 표현식이 상황(실제 객체)
                              //    에 따라 다르게 동작하는 것
                // 객체지향 언어의 3대 특징 : 캡슐화(private, public),
                //                          상속
                //                          다형성

                // 다형성은 OCP 를 만족하는 아주 좋은 코딩 스타일입니다.
                // 위 "s.Draw()" 는 새로운 도형이 추가되어도 
                // 수정될 필요 없습니다.
                }
            }
        }
    }
}


