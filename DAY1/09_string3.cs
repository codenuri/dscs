using System;
using static System.Console;

// 43 page 이야기
// 아래 코드는 항상 새로운 string 객체 생성
string s1 = new string("AAA");
string s2 = new string("AAA");

// 아래 코드는 string intern pool 에 
// string 객체를 만들고, s3, s4 가 공유. 
string s3 = "BBB";
string s4 = "BBB";

WriteLine($"{object.ReferenceEquals(s1, s2)}"); // False
WriteLine($"{object.ReferenceEquals(s3, s4)}"); // True

// 결론
// string 은 되도록 "단축 표기법(편의 표기법이라고도 합니다.)"
// 사용하세요
