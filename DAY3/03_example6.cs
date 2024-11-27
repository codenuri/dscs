// 배열은 참조 타입입니다.
// 아래 2줄 실행시 메모리 그림을 생각해 보세요
int[] x1 = { 1, 2, 3 };
int[] x2 = x1;


// C# 은 디자인 패턴을 아주 많이 사용해서 설계된 언어 입니다.
// (prototype, decorator, adapter 등 수많은 패턴을 적용한 언어)

int[] x3 = (int[])x1.Clone(); // prototype 패턴
                              // 캐스팅이 필요한 이유는 인터페이스 배운후 설명
                              // 지금은 Clone 에 집중

x1[0] = 10;

// 아래 결과 예측해 보세요
Console.WriteLine($"{x1[0]}"); // 10
Console.WriteLine($"{x2[0]}"); // 10
Console.WriteLine($"{x3[0]}"); // 1

Console.WriteLine($"{object.ReferenceEquals(x1, x2)}"); // True
Console.WriteLine($"{object.ReferenceEquals(x1, x3)}"); // False

// C#을 정말 잘하려면
// 1. C# 문법을 대략 익히세요
// 2. 디자인 패턴을 학습하세요
// 3. 다시 디자인을 알고 있는 상태에서 다시 C#을 보세요!!!
// 4. WPF 도 모두 디자인 패턴으로 설계된 라이브러리 !!!
//   => WPF 자체보다 디자인이 중요