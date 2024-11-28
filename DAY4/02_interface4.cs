using static System.Console;

// 2개의 인터페이스에 있는 메소드 이름이 동일
interface IA { void M1(); }
interface IB { void M1(); }

// 
class Example : IA, IB
{
    // 아래 처럼만들면 IA, IB 모두 구현한것
    // public void M1() { WriteLine("M1"); }

    // 아래 처럼 구현도 가능
    //    public void M1() { WriteLine("M1"); }
    //    void IB.M1() { WriteLine("IB.M1"); }

    // 2개 모두 명시적 구현도 가능.
    // 이경우는 객체 자체의 타입으로는 호출 안됨
    void IA.M1() { WriteLine("IA.M1"); }
    void IB.M1() { WriteLine("IB.M1"); }
}

class Program
{
    public static void Main()
    {
        Example e = new Example();
        IA ia = e;
        IB ib = e;

        e.M1();     // M1
        ia.M1();    // M1
        ib.M1();    // IB.M1
    }
}