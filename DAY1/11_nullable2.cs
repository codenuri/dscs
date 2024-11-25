using static System.Console;

// 58 page

// int  : ���� �Ѱ� ����
// int? : ���� �Ѱ� ����(value) + bool ����(hasValue)


int n = 0;

// #1. int? <= int : �׻� ����
int? n1 = n; // n1.Value = n
             // n1.hasValue = True;



// int <= int?
// int n2 = n1; // error. n1 �� null(�� ����) �����ϼ� ����.

int n2 = (int)n1;   // ok. 
                    // ��, n1 == null �̸� ��Ÿ�ӿ���(���ܹ߻�)

int n3 = n1.Value;  // ok
                    // ��, n1 == null �̸� ��Ÿ�ӿ���(���ܹ߻�)

//if ( n1 != null )
if ( n1.HasValue )  // ���� ���� �ǹ�. 
{
    int n4 = n1.Value; // �׻� ����
}

int n4 = n1.GetValueOrDefault();  // null �̸� ����Ʈ��(0) ��ȯ
int n5 = n1.GetValueOrDefault(3); // null �̸� 3 ��ȯ