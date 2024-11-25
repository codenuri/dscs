string s = null;

// #1. null 인 객체의 메소드를 사용하는 것은 런타임에러 입니다.
// s.ToString(); // error. 예외 발생

// #2. 모든 객체는 되도록 초기값을 가지는 것이 좋습니다.
//     즉, null 이 아닌 상태를 유지 하게 하는 것이 안전.
//     null 상태가 필요없는 변수는 null 불가능 타입을 사용하는것이 안전

// #3. value type 은 사용자가 선택 가능합니다.
int  n1 = 10;       // null 불가능 타입. 항상 안전!!
int? n2 = null;     // null 가능 타입. 유연성이 있지만 안전하지 않음.

// #4. 그런데, reference type 은 항상 null 가능하므로
//    선택할수 없습니다. (항상 안전하지 않음)

// #5. 그래서 C# 8.0 부터 nullable reference 라는 문법 도입(65p)
string s3 = null;  // null 불가능 타입
                    // null 을 넣으면, 컴파일 에러는 아니지만
                    // 경고 발생
string? s4 = null; // null 가능 타입.
