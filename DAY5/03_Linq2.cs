using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] arr = { "kim", "park", "choi", "lee", "jung" };

        // 아래 코드는 마치 SQL 처럼 보입니다.
        // 그래서 이 기술의 이름이
        // "Language INtegrated Query" => "LINQ" 입니다.

        // C# 초기에는 없다가 나중에 extension method 문법으로
        // 배열및 대부분의 컬렉션에 추가된 기능

        //  Where, OrderBy, Select
        var names = arr.Where(s => s.Contains('i'))
                       .OrderBy(s => s.Length)
                       .Select(s => s.ToUpper());

        
        
        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

    }
}
