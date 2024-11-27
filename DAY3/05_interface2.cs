using static System.Console;

// C# 은 인터페이스로 메소드 이름을 약속합니다.
// IComparable 를 만들때를 생각해 봅시다.
interface IComparable
{
    // 그런데, 메소드 인자는 다양한 타입이 될수 있기 때문에
    // object 로 설계될수 밖에 없었습니다.
    //	int CompareTo(object obj);  // ~ C#8.0

    // 또한 C# 9.0 에서 nullable reference 의 등장으로
	// 아래 처럼 수정되었습니다.
    int CompareTo(object? obj);
}


class Label : IComparable  
{
	private string title;
	
	public Label(string s) => title = s;

//  public int CompareTo(Label obj)  // 이렇게 하면 편하지만...인터페이스를 먼저 설계하다보니
    public int CompareTo(object? obj) // 이렇게 만들수 밖에 없었다.
    {								  // 단, 아래 코드가 복잡해 보이지만.
									  // 성능저하는 많지 않다.(어차피 참조 일뿐.. )
									  // 그런데, value type 은 성능 저하 크다(Boxing에서)

		// #1. 인자로 Label 객체를 보내고 있지만 object 타입으로 받았으므로
		//     다시 Label 타입으로 캐스팅해서 사용해야 title 접근 가능합니다.

		// #2. 
		Label? other = obj as Label;

//		if (other == null) { } // 이렇게 하거나 아래처럼 ? 로 해결

		return title.CompareTo(other?.title);  
    }

    /*
	public int CompareTo(Label other)
	{
		return title.CompareTo(other.title);
	}
	*/
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		// 사용자 정의 타입인 Label 도 크기 비교가 되도록 해봅시다.
		// #1. C#의 다른 타입과 동일한 이름을 사용하는 것이 좋습니다.
		int ret = d1.CompareTo(d2);

		M1(d1); // #2. 이렇게도 되게 하려면 "IComparable" 인터페이스를
				//    구현하겠다고 표기해야 합니다.
	}

	public static void M1(IComparable c) { }

}

