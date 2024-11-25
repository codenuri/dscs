using static System.Console;

// C#의 모든 타입은 아래 2개중 한개 입니다.(39 page 표 )
// 1. Value Type 
// 2. Reference Type 

// 아래 코드를 보고
// 1. 메모리 그림을 그릴수 있어야 하고
// 2. 출력 결과를 예측할수 있어야 합니다.


// #1. int : value type
int n1 = 10;
int n2 = n1;

n1 = 20;
WriteLine($"{n1} {n2}");	// 20  10	


// #2. 배열은 reference type
// 참고. swift 의 배열은 value type 입니다. 
int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

// #3. string 은 class 로 설계. 즉, reference type 입니다.
string s1 = "AB";
string s2 = s1;

s1 = "XY";
WriteLine($"{s1} {s2}");   // "XY", "AB"
                            // => 어??? 그럼 value type 아닌가요 ?
                            // => 다음 소스에서 설명
                            // => 이 예제는 위의 2개만 알아 두세요
                            // 40 page 그림 참고