using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// python : for( e in x)
// C++    : for( int e : x)
foreach( int e in x )
{
	Write($"{e}, ");
}
WriteLine();


// 배열뿐 아니라 문자열, Collection 등을 모두 열거 가능.

string s = "ABCDEFGHIJ";

foreach( char e in s )
{
	Write($"{e}, ");
}

int n = 0;
foreach (var e in n) // error. 
{
}

// 거의 모든 언어에서 foreach(for)에 놓일수 있는 타입은
// => iterable 한 타입만 가능합니다.
// => 반복자(iterator, enumerator)를 가진 타입. 
// => C# 반복자가 있는 모든 타입의 객체는 GetEnumerator()
//    메소드가 있습니다.
s.GetEnumerator(); // ok
//n.GetEnumerator(); // error