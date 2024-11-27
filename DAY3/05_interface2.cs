using static System.Console;

// C# �� �������̽��� �޼ҵ� �̸��� ����մϴ�.
// IComparable �� ���鶧�� ������ ���ô�.
interface IComparable
{
    // �׷���, �޼ҵ� ���ڴ� �پ��� Ÿ���� �ɼ� �ֱ� ������
    // object �� ����ɼ� �ۿ� �������ϴ�.
    //	int CompareTo(object obj);  // ~ C#8.0

    // ���� C# 9.0 ���� nullable reference �� ��������
	// �Ʒ� ó�� �����Ǿ����ϴ�.
    int CompareTo(object? obj);
}


class Label : IComparable  
{
	private string title;
	
	public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
		return title.CompareTo(obj);
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

		// ����� ���� Ÿ���� Label �� ũ�� �񱳰� �ǵ��� �غ��ô�.
		// #1. C#�� �ٸ� Ÿ�԰� ������ �̸��� ����ϴ� ���� �����ϴ�.
		int ret = d1.CompareTo(d2);

		M1(d1); // #2. �̷��Ե� �ǰ� �Ϸ��� "IComparable" �������̽���
				//    �����ϰڴٰ� ǥ���ؾ� �մϴ�.
	}

	public static void M1(IComparable c) { }

}

