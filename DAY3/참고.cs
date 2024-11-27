// 참고.cs

void f1(int  n) { }
void f2(int? n) { }

f1(10);     // ok
f1(null);   // error

f2(10);     // ok
f2(null);   // ok

int  n1 = 10;
int? n2 = 10;

f1(n1);
f1(n2);

f2(n1);
f2(n2);
