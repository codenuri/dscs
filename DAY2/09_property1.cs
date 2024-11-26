// public field vs setter/getter
class Person1
{
    public int age;
}

class Person2
{
    private int age;    

    public int  GetAge() => age;

    public void SetAge(int value) 
	{ 
		if ( value > 0 )
			age = value; 
	}
}

class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
		Person2 p2 = new Person2();
      
        // publie field 라면 직접 접근 가능
        // => 사용하기 쉽고, 가독성도 좋습니다.
		p1.age = 10;
		int n1 = p1.age;

        p1.age = -10; // 하지만 이방식은 안전하지 않습니다

        // setter/getter 사용
        // => 위 보다는 불편합니다.
        p2.SetAge(10);
		int n2 = p2.GetAge();

        p2.SetAge(-10); // 이 방식은 안전합니다.
	
    }
}
