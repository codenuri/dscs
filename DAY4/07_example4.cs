using static System.Console;


class Program
{
    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        Array.Sort(x);  // ���� ���� ���� �Դϴ�.

        for(int e in x)
            Write($"{e}, "); // 1, 3, 4, 6, 8

        WriteLine(); // ����

        // ���� ���� ������ ������ 
        // �ٽ� : ���Ľ� �ʿ��� 2���� ����� �񱳸� ��� ���� ����ڰ� ����

//        Array.Sort(x, �޼ҵ�);

        Comparison<int> c;
    
    }

 

}