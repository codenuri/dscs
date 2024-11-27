using static System.Console;


// 카메라를 먼저 만들지 말고
// 카메라 제조사와 카메라 사용자 사이에 지켜야할 규칙을 먼저 설계해 봅시다.
// 규칙 : 모든 카메라는 아래 인터페이스를 구현해야 한다.

interface ICamera
{
    void Take();    // 1. 메소드 이름만 표기(구현없음)
                    // 2. 접근 지정자도 표기하지 않음. 
}
// 이제 카메라가 없지만,  규칙이 있습니다.
// 카메라 사용자는 "규칙(인터페이스이름)" 대로만 사용하면 됩니다.

class People
{
    public void Use(ICamera camera) { camera.Take(); }
}

// 이제 모든 카메라 제조사는 규칙을 지켜야 합니다.
// ICamera 로 부터 상속받고, Take() 구현을 제공해야 합니다.
class Camera : ICamera
{
    public void Take() => WriteLine("Take a picture");
}

class HDCamera : ICamera
{
    public void Take() => WriteLine("Take a HD picture");
}

class FHDCamera : ICamera
{
    public void Take() => WriteLine("Take a FHD picture");
}

class Program
{
    public static void Main()
    {
        People p = new People();

        Camera c = new Camera();
        p.Use(c);

        HDCamera hc = new HDCamera();
        p.Use(hc);

        FHDCamera fhc = new FHDCamera();
        p.Use(fhc);

    }
}

// 강한 결합(tightly coupling)
// => 하나의 클래스가 다른 클래스 사용시 "클래스 이름"을 직접 사용하는것
// => 유연성 없는 경직된 디자인
// => OCP 를 만족할수 없다.


// 약한 결합(loosely coupling)
// => 하나의 클래스가 다른 클래스 사용시 규칙을 담은 "인터페이스 이름"
//    을 통해서 접근 하는 것
// => 유연성 있는 디자인
// => OCP 를 만족한다.

// 결국 객체지향 디자인은 "규칙(인터페이스)"를 먼저 만들자는 것이 핵심!!
