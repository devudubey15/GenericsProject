using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
	class Animal { }
	class Emplyee
	{
		public string Name {set; get;}
		public int Id { set; get; }

		public override string ToString()
		{
			return string.Format("id: {0} \nname: {1}",Id,Name);

		}

	} 
	internal class Nongenericcollection
	{
		static void Main(string[] args)
		{
			ArrayList arrayList = new ArrayList { 
				new Emplyee{Id=4654, Name="raj"},
				new Emplyee{Id =9889,Name="rahul"},
				new Emplyee{Id = 78887 ,Name="rishabh"}
				};
			arrayList.Add(new Animal());
			foreach (var item in arrayList)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine("-------------------------------------------------------------------------------");
				Console.WriteLine();
			}
			Console.ReadLine();
			
		}
			
	}
}
