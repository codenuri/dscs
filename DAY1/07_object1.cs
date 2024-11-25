// 31 page
// 모든 것은 객체이다. - C# 언어의 핵심!!!
// "everything  is  object"

// C/C++/Java 의 int 는
// => 언어자체가 제공하는 타입(키워드)

// C# 의 int
// => struct 문법으로 만들어진 Int32 라는 타입의 별명
// => 따라서 int 형 변수도 "메소드(멤버 함수)"가 있습니다.
using System;

int n1 = 10;

string s1 = n1.ToString();
string s2 = 10.ToString();

int n2 = int.Parse(s2);

// C#의 모든 타입은
// => struct 또는 class 문법으로 만들어 진것!!
// => 따라서 모든 변수(객체)는 메소드가 있다.

// 용어
// n1.ToString(); // C++ 은 멤버 함수
//                // java, C# 은 메소드 라고 합니다.

