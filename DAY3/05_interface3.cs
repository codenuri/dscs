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
        Label d2 = d1; // reference type 이므로 같은 객체를 가리키게 됩니다.

        // d1의 복사본을 생성하는 메소드를 제공해 봅시다.
        Label d3 = d1.Clone();

    }


}

