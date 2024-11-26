using static System.Console;

// 90 page



class Car 
{
    private int speed = 0;

    public int cnt = 0;

    public Car() { ++cnt; }    
}
class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        // Car 객체를 몇대나 생성했는지 알고 싶다.
        WriteLine($"{c1.cnt}");
    }
}