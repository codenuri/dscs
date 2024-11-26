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
	// => ������, ȣ���Ҷ� ��� ǥ���ؾ� �մϴ�. 
    public static void Inc2(ref int x)
    {
        ++x;    // ���纻 �ƴ� ���� ����( 79 page �Ʒ� �׸�)
    }
    public static void Main()
	{
		int n = 0;
		Inc1(n);
		WriteLine(n); // 0

        Inc2(ref n);	// ������ ������ �޶�.
        
        WriteLine(n);   // 1

		// C# 1.0 ~ ������ ref �� �޼ҵ� ���ڸ� �����߽��ϴ�.
		// C# 7.0 ���� ���������ε� ref ��밡���մϴ�.

		ref int r = ref n;  // ref local �̶�� ����
							// C++ : int& r = n

		r = 20;

		WriteLine(n); // 20 
    }
}