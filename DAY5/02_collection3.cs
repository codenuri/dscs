using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

class Program
{
    public static void Main()
    {
        // 데이타를 메모리에 어떤 형태로 보관하는가(자료구조)에 따라
        // 다양한 컬렉션이 존재 합니다

        // List<>       : 모든 요소가 연속된 메모리(배열과 동일)
        //                  [] 연산가능

        // LinkedList<> : 모든 요소가 연속된 떨어진 메모리
        //                  [] 연산 안됨 



        // 모든 요소 순환(열거, 검색)은 List 가 빠르지만
        // 중간 삽입은 LinkedList 가 빠릅니다.

        // 프로그램에서 어떤 연산을 많이 하는가에 따라 컬렉션을 선택하세요
        // 단, 잘모르면 List<> 사용하세요

        List<int>       c1 = new List<int>();
        LinkedList<int> c2 = new LinkedList<int>();

        for(int i = 0; i < 10; i++)
        {
            c1.Add(i);
            c2.AddLast(i);
        }
    }
}