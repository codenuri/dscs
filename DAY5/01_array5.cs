using static System.Console;

// 배열에 대해서 어떤 연산을 하고 싶다면
// 1. 속성을 찾으세요. - 크기등  
// 2. 메소드가 있는지 찾으세요
// 3. Array 의 static method 에서 찾으세요
// 4. extension method(LINQ) 에서 찾으세요

// #1. array method
int[] arr1 = { 1, 2, 3, 4, 5 };
int[,] arr2 = { { 1, 2,3 }, { 3, 4, 5 }};

WriteLine(arr1.Length); // 5
WriteLine(arr2.Length); // 6
WriteLine(arr2.GetLength(0)); // 2
WriteLine(arr2.GetLength(1)); // 3



/*
// method from object - 4개(non-static)
arr.GetType();
arr.ToString();
arr.GetHashCode();
arr.Equals();

// method from Array - 10개(non-static)
arr.GetEnumerator();
arr.SetValue();
arr.GetValue();
arr.Initialize();
arr.Clone();
arr.CopyTo();
arr.GetLength();
arr.GetLongLength();
arr.GetLowerBound(); // 구글 "C# array GetLowerBound" 검색
arr.GetUpperBound();
*/


