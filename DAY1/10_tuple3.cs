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


// #3. 아래 2줄의 차이점을 명확히 알아 두세요
(int a1, int a2, int a3) t2 = (1, 2, 3);
(int b1, int b2, int b3)    = (4, 5, 6);

int a1 = 0; // ok
//int b1 = 0; // error

WriteLine($"{t2.a1} {t2.a2} {t2.a3}");
WriteLine($"{b1} {b2} {b3}");
