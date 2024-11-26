using static System.Console;

// 프로그램에서 날짜를 자주 사용하게 됩니다.
// #1. Date 타입을 설계하자

class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int y, int m, int d) => (year, month, day) = (y, m, d);

    // Getter/Setter 를 제공해야 합니다.
    public int GetMonth() => month;

    public void SetMonth(int m)
    {
        if (m >= 1 && m <= 12)
            month = m;
    }
       
}

class Program
{
    public static void Main()
    {
        Date date = new Date(2024, 11, 26);

//      date.day = 50; // error. private
        date.SetMonth(12); // ok. setter/getter 사용
    }
}