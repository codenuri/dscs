// #1. 
// 소스 확장자 : .cs
// 빌드하는 법 : Ctrl + F5
// 생성된 실행 파일 : bin/debug/net8.0/First.dll - IL 코드
//                           First.exe - CLR을 배포가능하게

// #2. ILDASM 이야기
// ILDASM : IL 언어의 Dis assmebler
// visual studio 의 도구 메뉴 - ILDASM 실행 
// 없는 경우 
// 윈도우OS 의 시작 누른후에
// "developer.... 검색" 후 나타나는 명령창 실행
// 1. ILDASM 에서 파일 메뉴 열기, First.dll 열어보세요

// #3. C# 컴파일러
// => csc.exe
// => 개발자 명령 프롬프트에서만 사용가능(developer command prompt)
// => Program.exe 로 생성된
//   (실행파일안에 IL 과 CLR 모두 포함)
//   한개의 실행파일로 배포 가능.

System.Console.WriteLine("Hello, World!");
