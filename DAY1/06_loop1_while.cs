using static System.Console;

// while : C�� ���� ����.
//	       ���ǽĿ��� bool ���� ����. 

int cnt = 0;
while( cnt < 10 )
{
	Write($"{cnt}, ");
	++cnt;
}
WriteLine(); // ����

cnt = 0;
while( true )
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
}

//while( cnt ) {} // error. ���� �̸��� �ȵǰ�
					// while ( cnt != 0) ���� bool�� ��
