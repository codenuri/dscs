// 프로젝트내의 다른 파일에서도 사용가능한 using
// 다른 파일에서도 아래 using 이 동일하게 적용 ( C# 10.0)
// => 12 page
/*
global using System;
global using static System.Console;

Write("Hello, ");
WriteLine("C#");
*/

// using System 이 없지만 아래 코드가 에러가 발생하지 않습니다.
// 
Console.WriteLine("hello");