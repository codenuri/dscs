// null - 52 page ~ 

// #1. reference type 의 변수는 null 로 초기화 될수 있습니다.
string s1 = "hello";
string s2 = null;	// ok	

// #2.value type 의 변수는 null 로 초기화  될수 없습니다.
int n1 = 0;
// int n2 = null;	// error

// #3. Nullable<int> 는 null 이 될수 있습니다.
Nullable<int> n3 = null;


