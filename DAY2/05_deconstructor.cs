using static System.Console;

// 89 page

class Point3D
{
    private int x, y, z;
    public Point3D(int a, int b, int c) => (x, y, z) = (a, b, c);
}
class Program
{
    public static void Main()
    {
        Point3D p = new Point3D(1, 2, 3); // constructor 

        // p 가 가진 x, y, z 를 얻고 싶다.
        // 방법 #1. 아래 처럼, GetX(), GetY(), GetZ()를 만드는 방법
//        int x = p.GetX();
//        int y = p.GetY();
//        int z = p.GetZ();

        // 방법 #2. deconstruction 기술 사용
        int x, y, z;
        (x, y, z) = p; // 이 코드를 아래 처럼 변경하기로 약속되어 있습니다.
                       // p.Deconstructor(out x, out y, out z)
                       


    }
}