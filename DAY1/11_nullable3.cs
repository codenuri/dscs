string s = null;
int?   n = null;

// null 인지 조사하는 방법 
if ( s == null ) {}
if ( n == null ) {}

if ( s is null ) {}
if ( n is null ) {}

// 아래 방법은 Nullable 만 가능, reference type 은 안됨.
// s : string 타입 객체
// n : int 타입이 아닌 Nullable<int> 타입
if ( s.HasValue ) {} // error
if ( n.HasValue ) {} // ok. Nullable<T> 가 제공하는 속성

int ret1 = n.GetValueOrDefault();
string ret = s.GetValueOrDefault(); // error.

// 핵심
// null 관련 코딩 작성시
// => 원래 reference type 인지 ?
// => Nullable<T> 인지를 잘 구별하세요??
//    Nullable<T> 만 제공하는 메소드가 몇개 있습니다.