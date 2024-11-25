using static System.Console;

// is, as - 72 page

string s = "hello";

// #1. C#에서 모든 변수(객체)는 object로 가리킬수 있습니다.
//     (내일 자세히 설명)
object obj = s;

// #2. obj 를 사용하면 String 고유의 메소드는 사용안됨.
//obj.String 고유 메소드() // error


// string s1 = obj; // error

string s1 = (string)obj; // ok
                    // 단, obj 가 가리키는 타입이  string이 아니면
                    // 예외 발생.

// 결국, 조사후에 캐스팅 해야 합니다.

// #1. is 연산자로 조사후 캐스팅 

if ( obj is string )
{
    string s2 = (string)obj; 
}

// 아래 코드 꼭 외워 두세요
if (obj is string s3)
{
    // s3 사용   
}

// #2. as 연산자 사용
//string s4 = (string)obj;    // 실패시 예외
string s4 = obj as string;  // 실패시 null 반환
              // obj 가 string 타입이면 캐스팅
              // 아니면 null 반환.

