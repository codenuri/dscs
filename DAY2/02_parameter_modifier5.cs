using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // int.Parse : ���ڿ��� ������ ����
        //			  
        int n1 = int.Parse("10");    // ok. ����
        int n2 = int.Parse("Hello"); // ����. ���� �߻�


        // int.TryParse : ���� ����, ����/���� ��ȯ������ ����
        //                ��� �������� out parameter �� ����
        int ret;
        bool b = int.TryParse("Hello", out ret);

        bool b2 = int.TryParse("Hello", out int ret2); // �̷��Ե� ����


//      int? ret2 = int.ParseNullable("Hello"); // �� �޼ҵ尡 ������ 
                                                // ����� ?
                                                // ����� �����ϴ�.
                                                // ���� �����ڰ� ��û!~!
    }
}