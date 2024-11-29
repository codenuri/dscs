using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 주제 6. Set : 집합(수학, 여러개요소를 가진다.)

// HashSet<T>   : "해쉬테이블" - 검색에 최고
// SortedSet<T> : "RB Tree"   - 검색도 좋고 정렬을 유지
// 참고, 동적배열 검색이 느리다

class Program
{
    public static void Main()
    {
        SortedSet<int> ss = new SortedSet<int>(); // 

        ss.Add(15);
        ss.Add(10);
        ss.Add(20);
        ss.Add(23);
        ss.Add(18);

        // 크기순으로 정렬되어 있습니다.
        foreach (var n in ss)
            WriteLine(n);

        // Hash
        WriteLine(15.GetHashCode());
        WriteLine(15.GetHashCode());
        WriteLine(10.GetHashCode());


        HashSet<int> hs = new HashSet<int>();
        hs.Add(15); 
        hs.Add(10);
        hs.Add(20);
        hs.Add(23);
        hs.Add(18); // 18.GetHashCode() 로 해쉬값(바구니 번호)을 얻어서
                    // 해당 바구니에 보관

        // 삽입된 순서도 유지하지 못하고, 크기로 정렬되지도 않는다.
        // 무작위순서
        foreach (var n in hs)
            WriteLine(n);  

        WriteLine(hs.Contains(15));  // 15.GetHashCode() 로 바구니 번호 얻어서
                                    // 검색 
    }
}