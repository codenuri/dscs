// 변수의 초기값을 지정하는 방법.

int n1;		// 초기화 안됨.

// 아래 코드가 모두 0으로 초기화 하는 코드(v2 제외)
int n2 = 0;
int n3 = new int();

// C#의 모든 기본 타입은 default 값 이라는 개념이 있습니다. 24page
int n4 = default(int); // int n4 = 0;
int n5 = default;	   // int n5 = 0;

// 주로 Generic(template)에서 사용
//T n = default;


var v1 = default(int); // int v1 = 0;
var v2 = default;	   // error

// C# 의 모든 변수는 "new"로 만드는 것이 원칙 입니다.
// => 그런데, 표준 타입은 단축 표기법이 있습니다.
int n5 = new int(); // 정확한 표기법. 
int n6 = 0; // 위 코드의 단축 표기법. 