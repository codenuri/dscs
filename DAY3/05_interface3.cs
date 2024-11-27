using static System.Console;


class Label : IComparable, ICloneable
{
    private string title;

    public Label(string s) => title = s;

    public int CompareTo(object? obj) 
    {   
        Label? other = obj as Label;
        return title.CompareTo(other?.title);
    }

    public Label Clone()
    {
        return new Label(title);
    }
}

class Program
{
    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = d1; // reference type �̹Ƿ� ���� ��ü�� ����Ű�� �˴ϴ�.

        // d1�� ���纻�� �����ϴ� �޼ҵ带 ������ ���ô�.
        Label d3 = d1.Clone();

    }


}

