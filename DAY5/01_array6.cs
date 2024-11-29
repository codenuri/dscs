using System.Reflection;
using static System.Console;

// Array Static method

// #1. 배열의 instance method 는 단지 정보를 얻기만 합니다. - 크기등..

// #2. 정렬, 검색등은 모두 Array 의 static method 사용합니다

int[] arr = { 1, 2, 3, 4, 5 };

Array.Sort(arr);

// 동일이름의 메소드가 여러개 버전이 있습니다.
int idx1 = Array.IndexOf(arr, 3);
int idx2 = Array.IndexOf(arr, 3, 2);    // 2번째 부터 검색 
int idx3 = Array.IndexOf(arr, 3, 2, 2); // 2번째 2개만 검색


//-----------------------
/*
Array.AsReadOnly();
Array.BinarySearch();
Array.Clear();
Array.ConstrainedCopy();
Array.ConvertAll();
Array.Copy();
Array.CreateInstance();
Array.Empty();
Array.Equals();
Array.Exists();
Array.Fill();
Array.Find();
Array.FindAll();
Array.FindIndex();
Array.FindLast();
Array.FindLastIndex();
Array.ForEach();
Array.IndexOf();
Array.LastIndexOf();
Array.ReferenceEquals();
Array.Resize();
Array.Reverse();
Array.Sort();
Array.TrueForAll();
*/
