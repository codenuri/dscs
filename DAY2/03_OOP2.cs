using static System.Console;

// 객체지향 프로그래밍 개념
// => 필요한 타입을 먼저 만들자!!
// => 타입을 만드는 문법을 제공하는 언어가 "객체지향 언어"

// C struct : 데이타만 가지고 새로운 타입을 만들어야 한다.
//            관련된 함수를 넣을수 없다.

// 객체지향 언어의  class : 데이타 + 함수(메소드)를 묶어서 타입 설계

class Rect
{
    public int x1 = 0;
    public int y1 = 0;
    public int x2 = 0;
    public int x2 = 0;

    public int GetArea() { return (x2 - x1) * (y2 - y1); }
}
class Program
{
    public static void Main()
    {
        // 사각형이 필요하면 Rect 타입의 변수(객체)를 만들어서 사용하면 됩니다.
        // => int 4개를 사용할때 보다 가독성이 좋습니다.
        Rect rect = new Rect();
        int ret = rect.GetArea();  
    }
}


