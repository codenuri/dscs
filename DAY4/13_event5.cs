// delegate 의 대표적 활용 3가지

// #1. FindIndex, Sort 같은 메소드(알고리즘) 만들때 정책 함수를 받기위해 사용
// => 이경우는 event 사용하는 것 아닙니다.
int FindIndex(int[] arr, Predicate<int> match) 
{
}

FindIndex(x, IsEven );


// #2. Button 같은 클래스 만들때 내부적으로 어떤 일이 발생(Click)할때
//     외부에 알리기 위해서 함수 등록하기 위해 사용
class Button
{
    //  public ClickHandler Click = null;   // 이 코드 보다
    public event ClickHandler Click = null; // 이 코드가 안전
}

Button btn = new Button();
btn.Click += Foo;
btn.Click = Foo; // error

// #3. 람다 표현식을 담아서 함수 처럼 사용하기 위해서 사용
Func<int, int, int> add = (a, b) => a + b;