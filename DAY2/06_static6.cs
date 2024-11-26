// C# entry point 규칙 
// => 임의의 클래스를 만들고
// => Main 이라는 이름을 가진 static method 를 만들어야 한다.

// CLR 에서 "클래스이름.Main()" 으로 객체없이 호출. 

class Program
{
    public void M1() { }
    public static void M2() { }

    public static void Main()
    {
        M1(); // error. 객체가 없다.

        M2(); // ok. Program.M2()

        Program pg = new Program();
        pg.M1(); // ok.. 객체를 가지고 호출. 
    }
}