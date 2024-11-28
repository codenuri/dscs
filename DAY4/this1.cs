// github.com/codenuri/ dscs  에서 this.zip 있습니다.

// 받아서 압축푸신후에 4개 파일 DAY4 폴더에 복사해 놓으면 됩니다.

// this 개념
// => C#, Java, C++, Python 등, 거의 모든 객체지향 언어의 공통의 특징

class Point
{
    public int x = 0;
    public int y = 0;

    // 사용자 코드                   // 컴파일러가 변경한것
    public void Set(int a, int b)   // void Set(Point this, int x, int y)
    {                               // {
        x = a;                      //      this.x = a;
        y = b;                      //      this.y = b;
    }                               // }

    // 결국 this : 자신을 가리키는 참조. 
    //             p1.Set(1,2) => Set(p1, 1, 2) 에서 p1을 받을때 사용한 변수
    // 파이썬의 self
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        p1.Set(1, 2); // Set(p1, 1, 2)
        p2.Set(1, 2); // Set(p2, 1, 2)
    }
}
/*
class Point :
    def Set(self, a,b):
        self.x = a;

Point p = Point();
p.Set(1, 2)   // Set(p, 1, 2)
*/