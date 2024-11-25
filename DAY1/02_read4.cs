using System;

// Console.Read() : 입력 버퍼에서 한자 꺼내기
// int n = Console.Read();	// 입력 대기
                            // enter 를 입력해야 
                            // 입력완료

Console.Write("press any key >> ");

// 버퍼가 아닌 키보드에서 직접 입력
// => ENTER 필요 없음.
ConsoleKeyInfo cki = Console.ReadKey();     // 에코 있음.
//ConsoleKeyInfo cki = Console.ReadKey(true); // 에코 없음.

Console.WriteLine(cki.KeyChar); 
