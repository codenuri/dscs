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
// 위 코드에는 "Rect", "Circle" 만 있습니다.
// 그런데, 미래에 "Triangle" 이 추가된다면...
// => 해결책 #1 의 코드는 수정(추가)되어야 합니다.


// OCP 
// 기능 추가에는 열려 있어야(Open, 클래스가 나중에 추가되어도)
// 코드 수정에는 닫혀 있어야(Close, 기존 코드는 수정되면 안된다)
// 는 원칙(Principle)

// 개방 폐쇄의 법칙(Open Close Principle)

// 위 코드는 OCP 위반 입니다.

