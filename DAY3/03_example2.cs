using static System.Console;
using System.Collections.Generic; // List<> 를 사용하려면 필요
                                  // 그런데, C#10.0 부터
                                  // DAY3/obj/debug/net8.0/DAY3.GlobalUsing.g.cs 파일에 있음.
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
            else if (cmd == 2) c.Add(new Circle());
            else if (cmd == 9)
            {
                foreach( var s in c)
                    s.Draw();   // A. Error.
            }
        }
    }
}
// 위 코드는 어디서 ? 왜?? 에러일까요 ?
// => A 부분에서 s 의 타입은 Shape 입니다. List<Shape> 이므로
// => Shape 에는 Draw가 없어서 에러!
// 해결책은 뭘까요 ?
// => 다음소스에서.


