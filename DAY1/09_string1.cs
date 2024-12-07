using System;
using static System.Console;

// mutable, immutable, string - 41 page

// mutable   : 객체의 상태를 변경할수 있는것
// immutable : 객체의 상태를 변경할수 없는것

// int 는 mutable 타입입니다.
int n = 0;
n = 10; // ok. 변경가능. 

// string 은 immutable 한 타입 
string s1 = "AB";

char c = s1[0]; // ok
s1[0] = 'X';    // error. immutable !!


// 아래 코드가 중요 합니다.
string s2 = "AB";
        //  new string("AB")

s2 = "XY"; // 어?? 변경한거 아닌가요 ?
           // new string("XY"); // 위 한줄은 이 의미 입니다.


// 이제 아래 코드의 결과를 정확히 이해해 봅시다.
// 42 page 그림. 
string s3 = "AB";
string s4 = s3;

WriteLine($"{object.ReferenceEquals(s3, s4)}");

s4 = "XY";
    // new string("XY") 즉, 새로운 객체를 만든 것

WriteLine($"{s3} {s4}");
WriteLine($"{object.ReferenceEquals(s3, s4)}");

// object.ReferenceEquals(a, b) : a, b가 동일한 객체를 가리키는지 조사
