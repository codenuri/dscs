using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// generic vs non-generic

// C# 1.0 은 Generic 이 없었다!
// 그래서, C#1.0 때 도입된 컬렉션은 object 타입을 저장하도록 설계됨
// java 초기 컨테이너도 동일
/*
class ArrayList
{
    public void Add(object n) // 핵심 
    {
    }
}
*/


class Program
{
    public static void Main()
    {
        // object 기반 컨테이너 단점
        ArrayList c1 = new ArrayList();
        c1.Add(1);
        c1.Add(2);
        c1.Add("hello"); // 단점 1. 잘못 사용해도 에러 없음.
                         //         타입 안정성 나쁘다.

//      int n = c1[0]; // error. 반환 타입이 object
        int n = (int)c1[0]; // ok. 단점 2. 꺼낼때 캐스팅 필요

        // 단점 3. Boxing 현상이 있다. 매우 느리다.

        //==================================
        // Generic Container - C# 2.0 ~
        List<int> c2 = new List<int>();
        c2.Add(1);
        c2.Add(2);
//      c2.Add("hello"); // error. 타입 안정성이 뛰어 나고

        int n2 = c2[0]; // ok. 캐스팅이 필요 없다.

    }
}