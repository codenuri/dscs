// 배열은 참조 타입입니다.
// 아래 2줄 실행시 메모리 그림을 생각해 보세요
int[] x1 = { 1, 2, 3 };
int[] x2 = x1;


// C# 은 디자인 패턴을 아주 많이 사용해서 설계된 언어 입니다.
// (prototype, decorator, adapter 등 수많은 패턴을 적용한 언어)
int[] x3 = (int[])x1.Clone(); // prototype 패턴

x1[0] = 10;

// 아래 결과 예측해 보세요
Console.WriteLine($"{x1[0]}");
Console.WriteLine($"{x2[0]}");
Console.WriteLine($"{x3[0]}");
