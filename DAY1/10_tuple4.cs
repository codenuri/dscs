using static System.Console;

string Get1()       // 반환값이 한개 입니다 
{
    return "john";
}

(string, int) Get2() // 튜플을 사용해서 2개 반환 합니다. 
{
    return ("john", 30);
}

(string name, int age) Get3() // Named Member 를 사용합니다. 
{
    return ("john", 30);
}

var ret1 = Get1();  // ret1 은 string 
var ret2 = Get2();

WriteLine($"{ret2.Item1}  {ret2.Item2}");


var ret3 = Get3();
WriteLine($"{ret3.Item1}  {ret3.Item2}");
WriteLine($"{ret3.name}  {ret3.age}");