using static System.Console;

class Rect
{
    public int x1 = 0;
    public int y1 = 0;
    public int x2 = 0;
    public int x2 = 0;

    public int GetArea() { return (x2 - x1) * (y2 - y1); }

    // 생성자 : 객체를 만들때 자동으로 호출되는 메소드
    //         이름이 클래스 이름과 동일
    public Rect(int a, int b, int c, int d) => (x1, y1, x2, y2) = (a, b, c, d);
    //    {
    //        x1 = a; 
    //        y1 = b;
    //        x2 = c;
    //        y2 = d;
    //        (x1, y1, x2, y2) = (a, b, c, d);

    //    }
}
class Program
{
    public static void Main()
    { 
        Rect rect = new Rect(1, 1, 10, 10);

        int ret = rect.GetArea(); // 81
    }
}


