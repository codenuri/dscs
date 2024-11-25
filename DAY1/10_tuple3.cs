using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

// => �Ʒ� �ڵ�� int ���� 3���� tuple �� �����(����!)
// => t1�� tuple
var t1 = (a, b, c);



// #2. deconstruction
int x, y, z;

// => �Ʒ� �ڵ�� t1�̶�� tuple �� ���� ����, x, y, z �� ������
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// �� �ڵ�� �Ʒ� ó�� �Ҽ� �ֽ��ϴ�.(deconstruction)
(x, y, z) = t1; // �� �ڵ�� ���� ����(x, y, z) �� ����Ѱ�

(int a, int b, int c) = t1; // ����� deconstruction�� �ѹ���


WriteLine($"{x} {y} {z}"); // 1, 2, 3


// #3. �Ʒ� 2���� �������� ��Ȯ�� �˾� �μ���
(int a1, int a2, int a3) t2 = (1, 2, 3);
(int b1, int b2, int b3)    = (4, 5, 6);

int a1 = 0; // ok
//int b1 = 0; // error

WriteLine($"{t2.a1} {t2.a2} {t2.a3}");
WriteLine($"{b1} {b2} {b3}");
