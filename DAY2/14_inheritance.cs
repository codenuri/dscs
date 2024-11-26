// inheritance (상속 )

// "Person 타입" 을 먼저 설계하고 
class Person
{
    private string name;
    private int age;
}

// Person 을 확장해서 새로운 타입을 설계 합니다.
class Professor : Person
{
    private string major;
}
class Student : Person
{
    private string id;
} 

class Program
{
    public static void Main()
    {
        Student s = new Student();

    }
}
// 언어별 표기법
// C#     : class Student : Person
// C++    : class Student : public Person 
// Python : class Student(Person)
// Java   : class Student extends Person 
// Rust   : 상속 문법 없음. 

// 용어
// Person : Base(기반) class, Super class, Parent class

// Student : Derived(파생)_ class, Sub class, Child class 