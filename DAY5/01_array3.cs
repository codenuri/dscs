using static System.Console;

// #3. 배열을 생성하는 방법

int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[5];        // 모든 요소가 0

int[] arr3 = new[] { 1, 2, 3, 4, 5 };  //우변에 크기/ 타입 모두 생략가능

int[] arr4 = { 1, 2, 3, 4, 5 }; // 일반적인 코드

int[] arr5 = [1, 2, 3, 4, 5];   // C#12.0 이후 사용하는 방식
                                // Collection Expression
                                // 하나의 표기법으로 모든 컬렉션에 사용하기위해만든것
List<int> c1 = [1, 2, 3, 4, 5];  // 배열이 아닌 다른 컬렉션도 동일하게
List<int> c2 = { 1, 2, 3, 4, 5 };// error. {}는 배열 초기화만 가능


int[] arr6 = (int[])Array.CreateInstance(typeof(int), 5);

var arr7 = { 1, 2, 3, 4, 5 }; // error
var arr8 = [1, 2, 3, 4, 5];   // error
var arr9 = new[]{ 1, 2, 3, 4, 5 }; // ok


