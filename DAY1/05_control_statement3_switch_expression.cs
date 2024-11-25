int dayofweek = 1;

string s1 = "";

// switch statement - 
// => �������� switch ���
switch(dayofweek)
{
	case 0: s1 = "sun"; break;
	case 1: s1 = "mon"; break;
	case 2: s1 = "tue"; break;
	default : s1 = "unknown"; break;
}



// switch expression - �ٽ�!! ���� �θ� ���
// => �Ʒ� �ڵ忡�� _�� �����Ҽ� �����ϴ�.
// => switch��  �ݵ�� �Ѱ��� ���� ����� ���� �մϴ�.
string s2 = dayofweek switch 
			{
				0 => "sun",
				1 => "mon",
				2 => "tue",
				_ => "unknown"
			};


//const int c = 10; // ok
// c = 20; // error

// RUST �� �Ʒ� �ڵ嵵 ����(C ����� ? :  ���)
//let ret = if (a == 1) 10 else 20;
