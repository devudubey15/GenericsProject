using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
	//public class Demo
	//{
	//	public static void typeCheck<T,S>(T a , S b)
	//	{
	//		Console.WriteLine(typeof(T));
	//		Console.WriteLine(typeof(S));
	//	}
	//}

	// class Program1st_Generics
	//{
	//	static void Main(String[] args)
	//	{
	//		Demo.typeCheck(14, "join");
	//		Console.ReadLine();
	//	}
	//}
	class Generic_class<T,S>
	{
		T id;
		S name;
		public Generic_class(T id,S name )
		{
			this.id = id;
			this.name = name;
		}
		public T getId()
		{
			return this.id;
		}
		public S Getname()
		{
			return this.name;
		}
	}
	class Demo
	{
		static void Main(string[] args)
		{
			Generic_class<int, string> obj = new Generic_class<int, String>(4576 , "devasheesh");
			Console.WriteLine(obj);
			Console.WriteLine(obj.Getname());
			Console.WriteLine(obj.getId());
			Console.ReadLine();

		}
	}
}
