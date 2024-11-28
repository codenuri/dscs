using static System.Console;

delegate void MyFunc(int arg);

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
    public static void Main()
    {
        Test t = new Test();

        Test.SMethod(1); // static �޼ҵ�� Ŭ���� �̸����� ȣ��
        t.IMethod(1);    // instance �޼ҵ�� ��ü�̸����� ȣ��

        // #1. delegate �� Program Ŭ������ �޼ҵ� �� �ƴ� 
        //     �ٸ� Ŭ���� �޼ҵ� ����ϱ�. 
        MyFunc f1 = Test.SMethod;  // Ŭ�����̸�.static_method �� ���
        MyFunc f2 = t.IMethod;     // ��ü�̸�.instance_method �� ���
                                
                                // �ᱹ delegate ��ü f1, f2�ȿ���
                                // �޼ҵ��ּ�, ��ü �������� ��κ����˴ϴ�

        f1(10); // Test.SMethod(10)
        f2(10); // t.IMethod(10)


    }
}
