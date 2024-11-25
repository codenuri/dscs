using static System.Console;

// null conditional operator ( ?, ?[]) - 62 page

string s1 = "hello";
string s2 = null;

var ret1 = s1.ToString(); // ok. 객체가 존재.
var ret2 = s2.ToString(); // 런타임에러(예외 발생)

if ( ret2 != null)
{
    var ret2 = s2.ToString(); 
}
// 위 코드를 아래 처럼해도 됩니다.
var ret3 = s2?.ToString(); // s2 != null ? s2.ToString() : null;

// 
int[] arr = null;
int n = arr[0]; // 배열에 아직 없으므로 예외 발생

var n2 = arr?[0]; // arr != null ? arr[0] : null

// n2 의 데이타 타입을 생각해 보세요 ?
// => int 가 아닌 int? 타입이어야 합니다.