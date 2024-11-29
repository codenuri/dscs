using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

// 주제 6. 사용자 정의 타입과 해쉬, Equals(), GetHashCode()

class People
{
    public string name;
    public int age;

    public People(string n, int a) { name = n; age = a; }

    // 해쉬에서 값을 찾을때, 동일 객체가 아닌 동일 상태를 찾게 하려면
    // 반드시 사용자 타입에 대해서
    // Equals 와 GetHashCode() 를 override 해야 합니다.
    public override bool Equals(object? obj)
    {
        People people = obj as People;

        return name == people.name && age == people.age;
    }

    public override int GetHashCode()
    {
        // string 과 int 대한 해쉬 코드는 표준이 제공
        return name.GetHashCode() + age.GetHashCode();
    }
}

class Program
{
    public static void Main()
    {
        HashSet<People> hs = new HashSet<People>();

        People p1 = new People("Kim", 20);
        People p2 = new People("Lee", 30);

        hs.Add(p1);
        hs.Add(p2);

        People p3 = new People("Kim", 20);

        WriteLine(hs.Contains(p3)); // false 특정 사람 검색.
       
    }
}