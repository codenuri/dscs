using static System.Console;


class Car
{
    private int speed = 0;

    private static int cnt = 0; 

    public Car() { ++cnt; }

//  public int GetCount() {  return cnt; } // instance method
                                            // "객체이름.메소드이름()"
                                            // 으로 호출
                                            // 객체가 없으면 호출안됨

    public static int GetCount() { return cnt; }
                                // static method 
                                // 클래스이름.메소드이름() 으로 호출
}
class Program
{
    public static void Main()
    {
        // 이 위치에서 자동차 객체의 갯수를 알고 싶다.
        // => 아직 자동차를 만든적이 없지만, 갯수는 구할수 있어야 한다.
        WriteLine($"{Car.GetCount()}");

        Car c1 = new Car();
        Car c2 = new Car();

//      Car.cnt = 100;

        WriteLine($"{c1.GetCount()}"); // error. static method는
        WriteLine($"{Car.GetCount()}");// 클래스이름 으로 호출
    }
}