using static System.Console;

interface IMP3 
{
	void Play();
}

class Player : IMP3
{
    // 인터페이스의 메소드를 구현하는 일반적인 방식
    // public void Play() { WriteLine("Play MP3"); }

	// 인터페이스 메소드의 명시적 구현
	// #1. 인터페이스이름.메소드 이름으로 구현
	// #2. 접근지정자를 표기하지 않는다.
    void IMP3.Play() { WriteLine("Play MP3"); }
}

class Program 
{
	public static void Main()
	{
		Player player = new Player();

		player.Play(); // error. 명시적 구현으로 되어 있으면
					   //       인터페이스 타입으로 캐스팅해야만 호출가능

		((IMP3)player).Play(); // ok 

	}
}