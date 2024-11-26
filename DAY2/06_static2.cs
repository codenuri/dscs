using static System.Console;


class Car
{
    private int speed = 0;

    private static int cnt = 0; 

    public Car() { ++cnt; }

    public int GetCount() {  return cnt; }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

//      Car.cnt = 100;

        WriteLine($"{c1.GetCount()}");
    }
}