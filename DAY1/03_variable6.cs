using static System.Console;

int n1 = 10;
int n2 = 20;

// 변수 값 출력 하는 방법

// #1. 변수 한개
WriteLine(n1);

// #2. 서식화된 문자열
WriteLine("n1 = {0}, n2 = {1}", n1, n2);

// #3. $ 문자열
WriteLine($"n1 = {n1}, n2*2 = {n2*2}");