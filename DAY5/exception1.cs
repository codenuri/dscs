// exception1.cs

// 메소드가 실패 했을때 호출자에게 알리는 방법에 대해서 생각해 봅시다.

class Database
{
    public void Backup() 
    {
        // 실패 했다.. 호출자 에게 알려야 한다.
    }

    public void Remove() { }
}

class Program
{
    public static void Main()
    {
        Database db = new Database();
        db.Backup();
        db.Remove();
    }
}