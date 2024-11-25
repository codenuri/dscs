using static System.Console;


// #0. 타입 이름 : ValueTuple

// #1. ValueTuple 생성
ValueTuple<int, int, int> vt1 = new ValueTuple<int, int, int>(1, 2, 3);
ValueTuple<int, int, int> vt2 = ValueTuple.Create(1, 2, 3);
ValueTuple<int, int, int> vt3 = (1, 2, 3);
(int, int, int) vt4 = (1, 2, 3);
var vt5 = (1, 2, 3);

// C# 특징 : 특정 작업을 할수 있는 방법이
//          여러가지가 있습니다. 약간 혼란스러울수 있습니다.
//          "rich interface"

// #2. 주의
var a = (1);        // int a = 1, 즉 tuple 아님..
var b = (1, 2);		// (int, int) b = (1,2) 이 코드가 tuple


// #3. 요소 접근
//  Item1, Item2, ....
var vt6 = (1, 2, 3);
vt6.Item1 = 20;				// ok. immutable 
WriteLine($"{vt6.Item1}");	// 20


// #4. Named Member
(int,     int,     int)       vt7 = (1,2,3); // unnamed, Item1, Item2로접근
(int one, int too, int three) vt8 = (1,2,3); // named
                                             // 좌변(타입)에 이름 지정
var vt9 = (one:1, too:2, three:3 ); // 초기값에 이름 지정


WriteLine($"{vt8.one}");
WriteLine($"{vt8.Item1}");
WriteLine($"{vt9.one}");
WriteLine($"{vt9.Item1}");


