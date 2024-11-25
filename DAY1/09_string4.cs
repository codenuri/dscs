using System;
using System.Text;
using static System.Console;

// string        : immutable 문자열, 단축 표기법 지원
// StringBuilder : mutable 문자열,   단축 표기법 안됨. 반드시 new로
//                 reference type

//StringBuilder sb1 = "AB";	// error
StringBuilder sb1 = new StringBuilder("AB");
StringBuilder sb2 = sb1;

sb1[0] = 'X';

WriteLine($"{sb1} {sb2}"); // XB  XB 

// 모든 문자열 변경
//sb1 = "CD";  // error
sb1.Clear();
sb1.Append("CD");

WriteLine($"{sb1} {sb2}");  // CD   CD
WriteLine($"{object.ReferenceEquals(sb1, sb2)}"); // True

sb2 = new StringBuilder("XY");

WriteLine($"{object.ReferenceEquals(sb1, sb2)}"); // False