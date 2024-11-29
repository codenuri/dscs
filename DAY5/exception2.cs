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
        db.Backup();
        db.Remove();
    }
}