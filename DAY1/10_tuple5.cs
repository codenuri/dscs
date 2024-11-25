// 08_value vs reference1 에서 CPoint 만 복사.

class CPoint
{
    private int x;
    private int y;
    public CPoint(int a, int b) 
    { 
//      x = a; 
//      y = b;
        // 요즘은 위 처럼 하는 것이 아니라 아래 처럼하는것이 유행입니다.
        // 1. a, b 를 가지고 (a,b) 라는 튜플을 만든후
        // 2. x, y 라는 이미 선언된 변수에 deconstruction 을 한것
        // => 물론, 최적화 되어서 임시로 만들어 지는 tuple 은 제거됨
        (x, y) = (a, b);

        //  (x, y) t = (a, b); 위 코드는 t가 없으므로 deconstruction
    }
}