// Top Level Programming
// => C# 9.0 부터 지원
// => Main 메소드 없이.. 소스의 첫번째 문장 부터 실행
// => Python 과 유사. 
// => 원리는 교재 6page

System.Console.WriteLine("hello, C#");

// 위소스 빌드해서 DAY1.dll 생성되게 하고
// ILDASM 에서 
// DAY1.dll 열어 보세요

// 주의
// C# 은 함수 오버로딩을 지원 하지만, top level 방식은 에러
int square(int a) { return a * a; }
double square(double a) { return a * a; }