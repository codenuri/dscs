using static System.Console;

// static constructor - 92 page
class Train
{
    private int speed;

    public Train() { WriteLine("Train()"); speed = 50; }

    // C#에만 존재하는 static 생성자 문법
    // => public 을 붙이지 않습니다.
    static Train() { WriteLine("static Train(), static 생성자"); }
}

class Program
{
    public static void Main()
    {
        Train t1 = new Train(); // static 생성자 호출
                                // 생성자 호출                                
        Train t2 = new Train(); // 생성자 호출                                
        Train t3 = new Train(); // 생성자 호출                                
    }
}