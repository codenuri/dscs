using static System.Console;

// 프로그램에서 날짜를 자주 사용하게 됩니다.
// #1. Date 타입을 설계하자

class Date
{
    public int year;
    public int month;
    public int day;
}

class Program
{
    public static void Main()
    {
        Date date = new Date();
        date.day = 20;
    }
}