using static System.Console;

interface IMP3
{
    void Play();
    void Record();
}

class Player : IMP3
{
    public void Play() { WriteLine("Play MP3"); }

    // 인터페이스가 가진 메소드중 일부 메소드는
    // 사용하지 않고 싶을때
    // #1. 구현 자체를 하지 않으면 에러 이다.
    // #2. 구현을 제공하지만 예외 발생..
    void IMP3.Record() { throw new NotImplementedException(); }
}

class Program
{
    public static void Main()
    {
        Player player = new Player();
        player.Play();
//      player.Record(); // 명시적 구현이므로 error

        ((IMP3)player).Play(); // 예외 발생. 

    }
}