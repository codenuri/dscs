// 19 page
// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';
string s = "hello";


// #2. var
// => 우변을 보고 타입 추론
// => C++ 의 auto 키워드
var v1 = 10;		// int v1 = 10
var v2 = 3.4;		// double v2 = 3.4
var v3 = "hello";	// string v3 = "hello"
//var v4; // error


// #3. literal
int a1 = 10;		// 10진수
int a2 = 0x10;		// 16진수
int a3 = 0b10;		// 2진수

int a4 = 1000000;	// 큰 값을 사용하는 경우
int a5 = 1_000_000; // 자릿수 표기법 을 사용하면 편리
                    // 정확한 의미 : 컴파일러에게 _는 무시해 달라는것


