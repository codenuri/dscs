using static System.Console;

// 배열이 가진 속성(property)
// 모든 배열은 System.Array 로 부터 6개의 속성을 물려 받게 됩니다
// => 메소드와 속성(Property) 잘 구별하세요 
int[] arr = { 1, 2, 3, 4, 5 };

WriteLine($"{arr.Length}");     // 갯수 (5) - 32bit 타입으로 반환
WriteLine($"{arr.LongLength}"); // 갯수 (5) - 64bit 타입으로 반환
WriteLine($"{arr.Rank}");       // 차수  - 1차
WriteLine($"{arr.IsReadOnly}"); // 배열은 항상 false
WriteLine($"{arr.IsFixedSize}");// 배열은 항상 true
WriteLine($"{arr.IsSynchronized}"); // 배열은 항상 false
// 항상 True 인걸 왜 만들었나요 
//List<int> c = new List<int>();
//c.IsFixedSize; // 이 경우는 항상 false

