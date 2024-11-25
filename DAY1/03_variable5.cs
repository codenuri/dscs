using static System.Console;

// casting - 21 page
double d = 3.4;
//int n1 = d;		// error. C/C++ 언어는 가능.

int n2 = (int)d;	// ok. C언어와 동일한 방법. 


// nameof - 22 page. C# 6.0
// => 변수, 클래스, 속성의 이름을 "문자열" 변경
int color = 100;  // nameof(color) => "color"
string s = "abcd";

WriteLine($"{nameof(color)} : {color}");
				// "color"  : 100

WriteLine($"{nameof(s.Length)} : {s.Length}");
				// "Length" : 4

