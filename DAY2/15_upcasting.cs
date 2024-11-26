class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Dog dog = new Dog(); // ok

//      string s = new Dog(); // error. 

        // 핵심 #1. 기반 클래스 참조로 파생 클래스객체를 가리킬수 있다.
        // => "upcasting" 이라는 개념
        // => 가능한 이유를 메모리 그림을 생각해 보세요
        Animal a = new Dog(); // ok

        // 핵심 #2. 컴파일러는 컴파일 시간에 a가 가리키는 객체를 알수 없습니다.
        // => 아래 코드는 a가 가리키는 객체가 실행시간에 변경됩니다.

//        if (사용자 입력 == 1)
//            a = new Cat();



        // 핵심 #3. 기반 클래스 참조로는 기반 클래스 멤버만
        //         접근 가능합니다.
        // static type check : 컴파일 시간에 타입을 체크 하는 언어
        //                     잘못된 것을 컴파일 시간에 확인
        //                      (C++/C#/Java)

        // dynamic type check : 실행시간에 타입 체크
        //                      잘못된 것을 실행시간에 확인
        //                      (파이썬)
        a.Age   = 10; // ok
        a.Color = 10; // error
                      // 컴파일러가 컴파일시간에 a 가 Dog를 가리킨다는 확신이 없다.
                      // 그래서 무조건 에러!!

        // 핵심 #4. a 를 가지고 Dog 의 고유 멤버에 접근하려면
        //          Dog 타입으로 캐스팅해야 합니다.
        //          "Dog 가 맞다는 것을 컴파일러에게 알려주는 작업"

        ((Dog)a).Color = 10; 
                    // 단, 이경우 a가 가리키는 것이 Dog가 아니였다면
                    // 실행시간 에러(예외 발생)

    }
}