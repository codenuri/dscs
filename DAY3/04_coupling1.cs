using static System.Console;

// 109 page ~ 
// coupling
// => C# 뿐 아니라 모든 객체지향 언어의 개념

class Camera 
{
	public void Take() => WriteLine("Take a picture");
}

// 미래에 새로운 카메라가 나왔다.
class HDCamera
{
    public void Take() => WriteLine("Take a HD picture");
}


class People 
{
	public void Use(Camera c) => c.Take();
    public void Use(HDCamera c) => c.Take();
}

class Program 
{
	public static void Main()
	{
		People p = new People();
		
		Camera c = new Camera();
		p.Use(c);

        HDCamera hc = new HDCamera();
        p.Use(hc); // ??

    }
}

// 위 코드는 
// => HDCamera 가 추가 되었을때
// => 기존에 있던 People 클래스가 수정되었습니다.
// => "OCP"를 만족하지 못한 확장성 없는 유연하지 못한 디자인 입니다.