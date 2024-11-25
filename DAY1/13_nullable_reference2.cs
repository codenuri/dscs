#nullable enable

// C#8.0 이전 : 아래 코드 s1 은 에러 아님. 경고도 없음
// C#8.0 이후 : s1 은 경고. null 불가능한 타입으로 사용하자는 의도        

// C#8.0 이후라도
// => nullable reference 기능을 disable 하면 경고 아님.
// #1. 프로젝트 파일에서 "<Nullable>disable</Nullable>" 로변경
// #2. 소스 위에 #nullable disable또는 enable 추가

string s1 = null;
string? s2 = null;



Console.WriteLine(s1); 
Console.WriteLine(s2);