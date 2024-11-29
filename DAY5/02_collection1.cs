using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// Collection ( 185 ~ )

class Program
{
    public static void Main()
    {
        // Collection : 여러개의 값(객체)를 보관하는 도구(자료구조를 클래스로 만든것)
        //              C++ 에서는 "container" 용어 사용

        // 배열 크기가 고정된 collection
        // => 크기를 변경하거나
        // => 요소를 추가/삭제 할수 없다.
        int[] x = { 1, 2, 3 };


        // List<> :  크기 변경이 가능한 배열
        List<int> c = new List<int>();
        c.Add(1);
        c.Add(2);

        // C# 에는 다양한 컬렉션이 있습니다.
    }
}

