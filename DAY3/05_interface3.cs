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

    // object obj = new Lable() 즉,  Upcasting 되므로 아래 코드는 에러 아님.
    public object Clone()
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

        // #1. ICloneable 인터페이스를 구현하다 보니 반환 타입이 object 일수밖에
        //     없었습니다.
        // #2. 그래서 받을때 Label 타입에 담으려면 캐스팅 필요 합니다.
        Label d3 = (Label)d1.Clone();


        // int, double 처럼, int[] 도 타입입니다. [] 있다고 이상하게
        // 생각하지 마세요. 그냥 타입 이름이 int[] 입니다.

        int[] x1 = { 1, 2, 3 };
//      int[] x2 = x1.Clone(); // error.Clone 의 반환 타입은 object 이므로!!

        int[] x2 = (int[])x1.Clone();
    }


}

