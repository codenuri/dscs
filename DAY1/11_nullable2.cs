using static System.Console;

// 58 page

// int  : 정수 한개 보관
// int? : 정수 한개 보관(value) + bool 보관(hasValue)


int n = 0;

// #1. int? <= int : 항상 성공
int? n1 = n; // n1.Value = n
             // n1.hasValue = True;



// int <= int?
// int n2 = n1; // error. n1 이 null(값 없음) 상태일수 있음.

int n2 = (int)n1;   // ok. 
                    // 단, n1 == null 이면 런타임에러(예외발생)

int n3 = n1.Value;  // ok
                    // 단, n1 == null 이면 런타임에러(예외발생)

//if ( n1 != null )
if ( n1.HasValue )  // 위와 같은 의미. 
{
    int n4 = n1.Value; // 항상 성공
}

int n4 = n1.GetValueOrDefault();  // null 이면 디폴트값(0) 반환
int n5 = n1.GetValueOrDefault(3); // null 이면 3 반환