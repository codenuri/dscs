using System;

// C# 뿐 아니라 모든 언어의 공통의 특징
// => 입력 버퍼에서 입력 받는 다는 개념


Console.Write("input 1 >> ");
string s = Console.ReadLine();	 // 입력 대기
Console.WriteLine(s);			 // "ABCD"	


Console.Write("input 2 >> ");
int n = Console.Read();			// 입력대기
							    // "ABCD" 입력
Console.WriteLine("{0}, {1}", n, (char)n); 	//"A"


Console.Write("input 3 >> ");
n = Console.Read();		// 대기 없음.
Console.WriteLine("{0}, {1}", n, (char)n);	// "B"
 

