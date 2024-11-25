// 67 page
using static System.Console;

// if 문 
// 1. C언어와 거의 유사
// 2. 실행할 문장이 한줄이면 {} 생략가능 - 하지만 {} 를 사용하는 것을 권장
// 3. () 안에는 bool 로 계산되는 것만 가능. 정수형 변수사용안됨
int score = 75;

if ( score > 70 ) 
//{
	WriteLine("pass");
//}
else if ( score == 70 )
{
	WriteLine("reexam");
}
else 
{
	WriteLine("fail");
}

if ( score ) { } // error
				// C/C++은 가능
