using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

// 사용자 정의 타입과 Tree
// => 반드시 크기비교가 되어야만 사용자 정의 타입을 Tree에 넣을수 있습니다.
// => IComparable<T> 구현해야 합니다.
class People  : IComparable<People>
{
    public string name;
    public int age;
    public People(string n, int a) { name = n; age = a; }

    public int CompareTo(People? other)
    {
        return age.CompareTo(other.age);
    }
}



class Program
{
    public static void Main()
    {
        SortedSet<People> ss = new SortedSet<People>();

        People p1 = new People("Kim", 20);
        People p2 = new People("Lee", 30);
        People p3 = new People("kim", 10);

        ss.Add(p1);
        ss.Add(p2); 
        ss.Add(p3);

        WriteLine(ss.Contains(new People("Kim", 20)));   

    }
}