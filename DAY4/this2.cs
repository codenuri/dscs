class Point
{
    public int x = 0;
    public int y = 0;

    public void Set(int a, int b) => (x, y) = (a, b);

    public void Reset() // void Reset(Point this)
    {
        // 아래 표현도 결국 "객체.이름" 으로 접근한것입니다.
        // 사용자 코드   //  컴파일러가 변경한것
        x = 0;          //  this.x = 0
        y = 0;          //  this.y = 0
        Set(0, 0);      //  this.Set(0,0)

    }
}

class Program
{
    public static void Main()
    {
        Point pt = new Point();

        // instance field, instance method 의 접근은 
        // => "객체.이름" 으로 해야 합니다. (단, public 인 경우만)

        pt.x = 10; // 필드 접근
        pt.Set(10, 10);
        pt.Reset();
    }
}