using System;
using static System.Console;

// mutable, immutable, string - 41 page

// mutable   : ��ü�� ���¸� �����Ҽ� �ִ°�
// immutable : ��ü�� ���¸� �����Ҽ� ���°�

// int �� mutable Ÿ���Դϴ�.
int n = 0;
n = 10; // ok. ���氡��. 

// string �� immutable �� Ÿ�� 
string s1 = "AB";

char c = s1[0]; // ok
s1[0] = 'X';    // error. immutable !!


// �Ʒ� �ڵ尡 �߿� �մϴ�.
string s2 = "AB";
        //  new string("AB")

s2 = "XY"; // ��?? �����Ѱ� �ƴѰ��� ?
           // new string("XY"); // �� ������ �� �ǹ� �Դϴ�.


// ���� �Ʒ� �ڵ��� ����� ��Ȯ�� ������ ���ô�.
string s3 = "AB";
string s4 = s3;

s3 = "XY";
WriteLine($"{s3} {s4}");
