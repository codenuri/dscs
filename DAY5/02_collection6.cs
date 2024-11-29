using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 주제 5. Stack<T>, Queue<T> 
//         내부 자료구조 : 동적배열(연속된 메모리)

class Program
{
    public static void Main()
    {
        Queue<int> Q = new Queue<int>();

        Q.Enqueue(10);
        Q.Enqueue(20);

        WriteLine(Q.Dequeue()); // 꺼내고 제거
        WriteLine(Q.Peek());    // 꺼내기만 제거안함.
                                // 확인만할때 사용

        Stack<int> s = new Stack<int>();
        
        s.Push(10);
        s.Push(20);

        int n = s.Pop();
    }
}