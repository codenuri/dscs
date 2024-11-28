class List<T> where T : struct    // T 는 value type 이어야 한다.
{	
}

class Program 
{
	public static void Main()
	{
		List<int>    c1 = new List<int>();		// ok
		List<string> c2 = new List<string>();	// error

		Nullable<int> n = null;
	}	
}









/*
class C1<T> where T : struct           {}
class C2<T> where T : class            {}
class C3<T> where T : class?           {}
class C4<T> where T : notnull          {}
class C5<T> where T : unmanaged        {}
class C6<T> where T : new()    		  {}
// class C7<T> where T : base_class_name  {}
// class C8<T> where T : base_class_name? {}
// class C9<T> where T : interface_name   {}
// class C10<T> where T : interface_name?  {}


class C11<T> where T : class, IComparable<T>
{ 
}

class C12<T, U> where T : struct  
			    where U : class
{ 
}
*/