// exception1.cs

// C# 예외
// 1. Exception 에서 파생된 클래스를 설계합니다.
class DBBackupException : Exception { };

class Database
{
    public void Backup()
    {
        // throw : 예외를 던질때 사용하는 키워드.
        throw new DBBackupException();
    }
    public void Remove() { Console.WriteLine("DB Remove"); }
}

class Program
{
    public static void Main()
    {
        Database db = new Database();

        // 예외 가능성이 있는 메소드 호출시 try 블럭 안에서 해야 합니다.
        try
        {
            db.Backup();
        }
        catch (DBBackupException e)
        {
            Console.WriteLine("DB 예외 발생");
            Console.WriteLine(e.StackTrace); 
        }
        catch (Exception e)  // 위에서 잡히지 않은 모든 예외
        {
        }

        db.Remove();
    }
}