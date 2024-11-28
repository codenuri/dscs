using System;

// int Square(int n) { return n * n; }

// 람다 표현식의 정확한 모양
// #1. 메소드 모양에서 리턴타입과 메소드 이름 생략
// #2. 파라미터 리스트의 () 와 {} 사이에 => 
// #3. 반환 타입은 컴파일러가 return 문을 가지고 추론
Func<int, int> f1 = (int n) => { return n * n; };


Func<int, int> f2 = (int n) => n * n; // expression bodied 기법


Func<int, int> f3 = (n) => n * n;   // 좌변에 인자 타입이 있으므로 
                                    // (int n) 에서 int 생략가능

var            f4 = (int n) => n * n; // 이경우는 int 생략가능


Func<int, int> f5 = n => n * n;     // 인자가 한개라면 ()도 생략가능
                                    // 가장 간단한 표기법,
                                    // 더이상 줄일수 없다.

//var f6 =  (bool b) => b ? 1 : "one"; // error. 
                                     // 상황에 따라 다른 타입 반환
                                     // 해결책은 아래처럼
                                     // 반환타입 표시

var f7 = object (bool b) => b ? 1 : "one"; // 반환 타입 표기하는법
                                            // 반환타입(인자) => 구현

