using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Console;

// 주제 7. Dictionary - key 값을 가지고 value 를 보관하는 collection

class Program
{
    public static void Main()
    {
        // 값을 2개를 보관하는 자료구조
        KeyValuePair<string, string> p = new KeyValuePair<string, string>("mon", "월요일");

        WriteLine(p.Key); // "mon"
        WriteLine(p.Value);// "월요일"


        // Dictionary( C++ std::map )
        // => KeyValuePair 를 보관하는 hash table
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add("mon", "월요일");
        // "mon" 를 해쉬함수에 보내서(mon.GetHashCode()
        // bucket 에 keyValuePair("mon", "월요일") 보관

        // 쉽게 사용하려면 아래 처럼 [] 로 하면 됩니다.
        dic["tue"] = "화요일";

        WriteLine( dic["mon"] ); // 월요일
    }
}