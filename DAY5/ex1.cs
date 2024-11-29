// e1.cs
using System;
using System.Windows;

// 핵심 #1. 설정
// => WPF 를 사용하려면 WPF 라이브러리를 같이 빌드되게 해야 합니다.
// => 프로젝트 파일에서(WPF.csproj)

// 아래 2개 수정하면 됩니다.
// <UseWPF>true<UseWPF>  추가
// <TargetFramework >net8.0-windows</TargetFramework > 수정

class Program
{
    public static void Main()
    {
        MessageBox.Show("Hello, WPF");
    }
}