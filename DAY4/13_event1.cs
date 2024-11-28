using static System.Console;

class Button
{
	public void UserPressButton()
	{
		WriteLine("To Do Something"); 

		// 여기서 어떤 작업을 하게 되면
		// 모든 버튼이 같은 일을 하게 됩니다.

		// 일반적인 방식
		// 메소드를 등록했다가
		// 여기서 다시 등록된 메소드를 호출해야 합니다.
	}
}

class Program
{
	public static void Main()
	{
		Button btn1 = new Button(); // 이순간 GUI 버튼이 만들어 지고
		Button btn2 = new Button();
	
		btn1.UserPressButton(); // 사용자가 버튼을 누르면
		btn2.UserPressButton(); // 이 메소드가 호출된다고 가정. 		
	}
}