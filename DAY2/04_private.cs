using static System.Console;

// 용어 정리
//              데이타              함수
// C++          멤버데이타           멤버함수
// C#           필드                메소드


class Bike
{
    // public : 멤버가 아닌 다른 메소드에서 접근가능
    // public int gear = 0;

    // private: 자신의 메소드만 접근 가능. 
    private int gear = 0;

    // private 데이타는 메소드를 통해서만 변경할수 있게 해야 합니다.
    public void SetGear(int g)
    {
        if ( g > 0 && g < 21 )
            gear = g;
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        // b.gear = 5;  // ok
        // b.gear = -10; // 사용자가 실수했지만 에러가 아니다.
                         // 현실세계에 존재할수 없는 객체가 탄생
                         // private 이라면 에러!!
        b.SetGear(5);
        b.SetGear(-10);// 잘못된 값 전달시, 상태는 변하지 않는다.

        // 캡슐화 (encapsulation)
        // => 데이타를 private 에 놓아서
        // => 외부에 잘못된 사용으로 객체가 불안정해지는 것을 막는다.
        // => 객체는 잘설계된 메소드를 통해서만 변경가능하다.
    }
}


