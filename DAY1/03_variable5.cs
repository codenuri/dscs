using static System.Console;

// casting - 21 page
double d = 3.4;
//int n1 = d;		// error. C/C++ ���� ����.

int n2 = (int)d;	// ok. C���� ������ ���. 


// nameof - 22 page. C# 6.0
// => ����, Ŭ����, �Ӽ��� �̸��� "���ڿ�" ����
int color = 100;  // nameof(color) => "color"
string s = "abcd";

WriteLine($"{nameof(color)} : {color}");
				// "color"  : 100

WriteLine($"{nameof(s.Length)} : {s.Length}");
				// "Length" : 4

