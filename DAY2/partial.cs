// 클래스를 여러개 파일로 나누어 작업가능합니다.
string s;
// a.cs
partial class Example
{
    public void M1() { }
}

// b.cs
partial class Example
{
    public void M2() { }
}

// c.cs
Example e = new Example();
e.M1();
e.M2();

// 왜 여러개 파일로 분리하나요 ?
// 1. 클래스 멤버가 많아서 기능별로 분리
// 2. 사람 과 기계가 하나의 클래스를 같이 작업 - WPF 라이브러리.
//    (UI 코드는 기계가, event 처리는 사람이)

// 사람.cs
partial class MainWindow
{
    // event 처리만
}
// 기계.cs
partial class MainWindow
{
    // 사용자가 GUI(wizwig 방식)으로 만든 것을 가지고
    // 기계가 코드로 생성
}