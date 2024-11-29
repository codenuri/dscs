// exception1.cs

// 메소드가 실패 했을때 호출자에게 알리는 방법에 대해서 생각해 봅시다.

class Database
{
    // 방법 #1. 실패로 약속된 값 반환. 
    // 단점 : 호출자가 실패에 대한 처리를 하지 않을수도 있다.
    //       "실패에 대한 처리를 강제 할수 없을까 ?"


    public int Backup() 
    {
        // 실패 했다.. 호출자 에게 알려야 한다.
        return -1;
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