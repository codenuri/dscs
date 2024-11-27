using static System.Console;

// method override ( 104 page ~ )
// C++ 의 가상함수 이야기와 동일한 이야기

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}
class Dog : Animal
{
    // method override : 기반 클래스 메소드를 파생클래스가 다시 구현하는 것
    // C++ : 아래 처럼하면 ok.  C# : 경고 발생(명확히 하기 위해 new)를 표기하라는 것
    // public void Cry() { WriteLine("2. Dog Cry"); }

    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
		Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // 1. Animal.Cry
		d.Cry();    // 2. Dog.Cry 

        //----------------------------------
        Animal ad = d; // 실제 객체는 Dog,  참조 타입은 Animal 타입

//      if ( 사용자 입력 == 1) ad = a;  // <<== A


        ad.Cry(); // Animal.Cry 가 호출될까요 ? Dog.Cry 가 호출될까요 ?
                  // => 논리적으로는 Dog.Cry 가 맞습니다
                  // C++, C# : Animal Cry 호출
                  // Java, Swift, Objective-C, Python, kotlin 등 대부분 : Dog Cry
	}
}
// 아래 설명은 104 p 참고

// ad.Cry()를 어떤 함수(메소드)와 연결 할것인가 ?
// => 함수 바인딩(function binding) 이라고 합니다.

// 1. static binding : 컴파일 시간에 컴파일러가 함수 호출을 결정
//                     컴파일러는 ad 가 실제 어떤 객체를 가리키는지 알수없습니다.
//                     위에서 "A" 같은 코드가 있다면 실행시 변경가능하므로
//                     컴파일러가 아는 유일한 정보는 "ad" 자체가 Animal 이라는것
//                     따라서 컴파일러가 결정하면 Animal Cry 호출

// 빠르지만, 논리적이지 않다.
// C++/C# 기본 바인딩

// 2. dynamic binding : 실행 시간에 함수호출을 결정(어떤 함수로 연결할지)
//                      컴파일 시간에는 "ad" 가 가리키는 곳을 조사하는 기계어(IL) 생성
//                      실행시간에 실제객체를 조사후 해당 객체의 Cry 호출
//                      ad가 Dog 를 가리켰다면 Dog Cry 호출

// 느리지만 논리적이다.
// Java, Python, Swift 등 대부분 객체지향 언어의 기본 정책.
// C++/C# 의 virtual method(함수)
