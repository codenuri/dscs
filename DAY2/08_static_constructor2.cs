using static System.Console;

// 열차의 시간표는 매일 변경될수 있습니다
// => 모든 열차는 시간표을 알고 있어야 합니다.
// => 1번째 열차가 출발할때 그날의 일정이 결정됩니다.

class Train
{
    public static DateTime startTime; // 첫번째 열차의 출발시간

    public Train() 
    {
        // 여기서 startTime 를 초기화 하면
        // 열차가 생성될때 마다 변경됩니다.

        WriteLine($"1번째 열차 출발시간 {startTime.ToString()}");
    }
    static Train() 
    { 
        WriteLine("static Train(), static 생성자"); 

        startTime = DateTime.Now;

        // 핵심 : static field 초기화 를 실행시간에 최초에 1회만 하기 위해
    }
}

class Program
{
    public static void Main()
    {
        Train t1 = new Train();    
        Thread.Sleep(1000);
        Train t2 = new Train();
        Thread.Sleep(1000);
        Train t3 = new Train();                             
    }
}