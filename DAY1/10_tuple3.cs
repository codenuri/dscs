using static System.Console;

// #1. construction
int a = 1, b = 2, c = 3;

// => 아래 코드는 int 변수 3개로 tuple 을 만든것(생성!)
// => t1은 tuple
var t1 = (a, b, c);



// #2. deconstruction
int x, y, z;

// => 아래 코드는 t1이라는 tuple 의 값을 각각, x, y, z 에 담은것
x = t1.Item1;
y = t1.Item2;
z = t1.Item3;

// 위 코드는 아래 처럼 할수 있습니다.(deconstruction)
(x, y, z) = t1; // 이 코드는 변수 선언(x, y, z) 후 사용한것

(int a, int b, int c) = t1; // 선언과 deconstruction을 한번에


WriteLine($"{x} {y} {z}"); // 1, 2, 3


// #3. 아래 2줄의 차이점을 명확히 알아 두세요 - 49 page 아래 부분
(int a1, int a2, int a3) t2 = (1, 2, 3); // t2라는 튜플 생성, a1, a2, a3는
                                         // 각 요소의 이름.

(int b1, int b2, int b3)    = (4, 5, 6); // 위에 있는 t2라는 이름이 없습니다.
                                         // tuple destruction입니다.
                                         // int b1 = 4
                                         // int b2 = 5
                                         // int b3 = 6


int a1 = 0; // ok
//int b1 = 0; // error. 위 33번째 줄에서 이미 선언된 이름.

WriteLine($"{t2.a1} {t2.a2} {t2.a3}");
WriteLine($"{b1} {b2} {b3}");

// CLR via C# : 최고의 C# 서적으로 알려진 책. 2000년대 초반 서적


// 관심없는 멤버는 _로 표기
var tp2 = (1, 2, 3);

(int b1, _, int b3) = tp2;

/*
// 참고: C++
int arr[3] = { 1, 2, 3 };

auto[a, b, c] = arr; // C++17 부터 가능
auto[a, _, c] = arr; // C++26 부터 _도 가능.
                     // C++17 에서도 에러 아니지만
                    // _가 변수 이름이 됨
auto[x, _, y] = arr; // 따라서 한번 더 사용하면 에러!!
                     // 이미 선언된 변수
                    // C++26, 변수이름이 _ 라면
                    // 여러번 선언될수 있다는 문법 도입
*/