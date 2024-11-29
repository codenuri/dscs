using static System.Console;

// 메소드의 실패를 반환값 으로 알려주는 경우
// => 호출자가 실패를 무시할수 있습니다.
// => 이 경우 더욱 큰 문제가 될수 있습니다.
// => 호출자에게 실패를 반드시 처리 하라고 강제 할수 없을까요 ?
// => 예외(exception) 이라는 문법

class Database
{
    public Database(string dbname) { }

    public bool Backup()
    {
        return false;   // 실패를 반환 값으로 전달
    }
    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        db.Backup();    

        db.Remove();
    }
}
