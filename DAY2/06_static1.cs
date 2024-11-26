using static System.Console;

// 90 page



class Car 
{
    private int speed = 0;

    //  public int cnt = 0; // 객체당 한개씩 생성되는 필드
                            // 자동차 객체 각각의 특징을 표현

    public static int cnt = 0; // 모든 객체가 공유 하는 필드
                               // 자동차 각각의 특징이 아닌
                               // 모든 자동차의 공통의 특징을 표현

    public Car() { ++cnt; }    
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        // Car 객체를 몇대나 생성했는지 알고 싶다.
        WriteLine($"{c1.cnt}"); // error. 
        WriteLine($"{Car.cnt}"); // ok. static field 는
                                 // 객체가 아닌 클래스 이름으로 접근
    }
}