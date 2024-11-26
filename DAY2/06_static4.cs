using static System.Console;

class Date
{
    // 날짜 관련 다양한 연산을 하려면 월별 날짜수를 알아야 한다.
    // => 아래 데이타는 "날짜당 한개" 씩 필요한게 아니라.
    // => 모든 날짜 객체가 같이 사용해야 합니다.
    // => 이럴때 static 으로 해야 합니다.
    static int[] days = { 31, 28, 30, 31, 30, 31, 30, 31, 30, 31, 31, 31 }; // 데이타
                                                // 맞게 나중에 수정하세요

    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);

    public int GetMonth() => month;

    public void SetMonth(int m)
    {
        if (m >= 1 && m <= 12)
            month = m;
    }

    // 생성자, Getter/Setter 외에  Date 타입 사용자들에게 필요한
    // 좋은 메소드를 많이 제공해야 합니다.

    public Date AfterDays(int ds)
    {
        Date d = new Date(year, month, day + ds); // 잘못된 구현
        
        // 복습할때 제대로 구현해 보세요
        return d;
    }

    public static int HowManyDays(int m, int y = -1)
    {
        if ( y != -1 && m == 2)
        {
            // y 가 윤년인지 계산해서 반환해야 한다.
            // 복습시 해보세요. 
        }
        return days[m - 1];
    }
    // 동일한 이름의 메소드를 static, instance로 하는 경우도 많습니다.
    public bool IsLeapYear()
    {
        // 멤버 필드 year 를 가지고 조사
        return true;
    }
    public static bool IsLeapYear(int y)
    {
        // 인자 y 를 가지고 조사
        return true;
    }

}

class Program
{
    public static void Main()
    {
        Date today = new Date(2024, 11, 26);

        // 오늘부터 1000일 뒤는 몇일일까 ?
        Date target = today.AfterDays(1000);

        // 5월달이 몇일까지 있는지 알고 싶다.
        // => 특정 기준일(객체) 가 필요한 것은 아닙니다.
        // => static method로 설계 되어야 합니다.
//        Date d = new Date(0, 5, 0);
//        int ret1 = d.HowManyDays(); // 방법 #1. 객체를 만들고 사용하게 하자.
 
        int ret2 = Date.HowManyDays(5); // 방법 #2. 클래스 이름으로 호출가능하게
                                        //        하자
        int ret3 = Date.HowManyDays(2, 2024);

        // 윤년인지 조사하고 싶다.
        // 다음중 좋은 방법은 ?
        // => 2개 모두 제공하는 것이 좋은 구현 !!

        // 방법 #1. 객체를 만들고 조사하게 하자.
        Date to = new Date(2024, 11, 26);

        bool b1 = to.IsLeapYear();

        // 방법 #2. static method로 제공하자.
        bool b2 = Date.IsLeapYear(2024);


        // 내일 날짜를 구하는 메소드인 Tomorrow 는 
        // => 기준이 되는 날짜가 필요합니다.
        // => instance method로 설계 되어야 합니다.
        Date d3 = today.Tomorrow();  // 복습할때 구현해 보세요. 
    }
}