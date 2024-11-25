using System;

Console.Write("input yout age >> ");

// 정수 입력
// 1. 먼저 문자열로 입력 받고
// 2. 문자열을 => 정수(실수)로 변환해서 사용
string s = Console.ReadLine(); // "10"


// 입력된 문자열을 정수로 변경하는 2가지 방법
int n1 = Convert.ToInt32(s);
int n2 = int.Parse(s);      // 이방식이 널리 사용
                            // s = "hello" 등으로 정수변경이 안되면
                            // 런타입 에러(예외 발생)

Console.WriteLine($"{n1}, {n2}");


int n3 = 0;

// 실패시, 예외 대신 반환 값으로.. 
bool b = int.TryParse(s, out n3);
Console.WriteLine($"{b}, {n3}");



