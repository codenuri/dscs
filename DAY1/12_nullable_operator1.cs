using static System.Console;

// null-coalescing operator (?? 연산자)


int?   n1 = null;
string s1 = null;

// 
//int n2 = n1; // error
int n3 = n1.GetValueOrDefault(); // ok
int n4 = n1 ?? 0; // 위와 동일

string s2 = s1; // ok. reference type 은 null 이 가능하므로

string s3 = s1.GetValueOrDefault("ABC"); // error
              // 이 메소드는 Nullable<T> 만 제공

string s3 = s1 ?? "ABC"; // ok



