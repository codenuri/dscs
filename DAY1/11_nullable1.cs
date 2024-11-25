// null - 52 page ~ 

// #1. reference type 의 변수는 null 로 초기화 될수 있습니다.
string s1 = "hello";
string s2 = null;	// ok	

// #2.value type 의 변수는 null 로 초기화  될수 없습니다.
int n1 = 0;
// int n2 = null;	// error

// #3. Nullable<int> 는 null 이 될수 있습니다.
Nullable<int> n3 = null;
//Nullable<string> n4 = null; // error. 
                    // Generic 인자로 Value Type 만 가능

// 단축 표기법 존재
int? n4 = null; // Nullable<int> n4 = null 과 완전히 동일

