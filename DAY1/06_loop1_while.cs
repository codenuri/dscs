using static System.Console;

// while : C와 거의 동일.
//	       조건식에는 bool 값만 가능. 

int cnt = 0;
while( cnt < 10 )
{
	Write($"{cnt}, ");
	++cnt;
}
WriteLine(); // 개행

cnt = 0;
while( true )
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
}

//while( cnt ) {} // error. 변수 이름은 안되고
					// while ( cnt != 0) 같이 bool로 만
