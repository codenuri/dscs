using static System.Console;

// 파워 포인트 같은 프로그램을 생각해 봅시다.
// 1. 모든 도형을 타입으로 설계하면 편리 합니다.

// 2. 모든 도형 타입의 기반 클래스가 있으면
//    장점 1. 공통의 특징을 제공할수 있다.
//    장점 2. 모든 도형을 한개의 collection에 보관할수 있다.

class Shape
{
    private int color = 0;
}

class Rect : Shape 
{ 
    // x, y, w, h, 생성자등이 필요 합니다 - 생략
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
//      List<Rect> c = new List<Rect>();   // Rect 객체만 보관하는 collection
        List<Shape> c = new List<Shape>(); // 모든 도형 객체를 보관하는 collection
    }
}
