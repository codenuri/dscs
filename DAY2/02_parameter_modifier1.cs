using static System.Console;

// 79 page
class Program
{
	// �Ʒ� �޼ҵ�� ���纻 x �� �����մϴ�.
	// => call by value(C�� ���� )
	// => 79 page �� �׸�
	
	public static void Inc1(int x)
	{
		++x;	// ���纻 ����
	}

	// ref modifier
	// => ���纻�� �ƴ� ������ �޾ƴ޶�� �ǹ�
    public static void Inc2(ref int x)
    {
        ++x;    
    }
    public static void Main()
	{
		int n = 0;
		Inc1(n);
		WriteLine(n); // 0

        Inc2(ref n);	// ������ ������ �޶�.
        
        WriteLine(n);	// 1

    }
}