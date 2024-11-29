using static System.Console;

// #2. 배열과 타입
void print_type(object obj)
{
    Type? t1 = obj.GetType();
    Type? t2 = t1?.BaseType;
    Type? t3 = t2?.BaseType;

    WriteLine($"{t1?.Name} -> {t2?.Name} -> {t3?.Name}");
}



int[] arr1 = { 1, 2, 3 };
int[,] arr2 = { { 1, 2 }, { 3, 4 } };
int[][] arr3 = new int[3][];

// int[] 도 int, double 같은 타입입니다.

int   n = (int)3.4; // 이 코드를 이해 하는 분들이
int[] x = (int[])arr1.Clone(); // 이 코드를 어려워 합니다.
                               // 위와 같은 개념입니다.

// 모든 종류의 배열은 System.Array 로부터 파생됩니다.
print_type(arr1);
print_type(arr2);
print_type(arr3);






// 선언문과 타입에 대해서
// => 선언문에서 변수이름과 초기값을 제외하면 타입만 남게됩니다.

// C 언어 코드 입니다.
/*
int    n = 0;   // 변수이름 : n   타입 : int
double d = 0;   // 변수이름 : d   타입 : double

int x[3] = { 1, 2, 3 }; // x의 타입은 ? : int[3]
int[3] x = {1,2,3}; // 배열을 이렇게 했다면 더 쉽지 않았을까 ?
int[3]* p

// C 언어에서 포인터 변수는 해당 변수와 같은 타입으로 만들고
// 변수이름앞에 * 붙이면 됩니다.
int *p = &n;

int (*p)[3] = &x;
*/