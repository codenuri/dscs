// 클래스를 여러개 파일로 나누어 작업가능합니다.
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