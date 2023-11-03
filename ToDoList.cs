using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

//Create a program that simulates a simple to-do list application. The program should allow users to add tasks,
//remove tasks, display all tasks, and mark tasks as completed. Consider using a list to store the tasks
// i want to print every task by date on which they got added. also want to print the due date   

namespace GenericsProject
{
	public class KeyVAluePair
	{
		public string Key { get; set; }
		public string Value { get; set; }
	}

	class Task : KeyVAluePair
	{
		static Task()
		{
			Console.WriteLine("Welcome to your Todo App");
			Console.WriteLine();
			Console.WriteLine("your todo List is empty please add some content to it");
			Console.WriteLine();
			Console.WriteLine("Some Options Are Given Below Please Select One");
			Console.WriteLine();
			Console.WriteLine("1 for Add Task ");
			Console.WriteLine("2 for Remove Task");
			Console.WriteLine("3 for Display all Task");
			Console.WriteLine("4 To exit ");
			Console.WriteLine("");
		}
		
		List<KeyVAluePair> tasklist = new List<KeyVAluePair>() ;
		//public KeyVAluePair ref1;
		public KeyVAluePair classObj()//?
		{
			KeyVAluePair classobj = new KeyVAluePair { Key = addTask(), Value = addTaskDecription() };

			return classobj;
		}

	public string addTask()
		{
			Console.WriteLine("a task you want to add \n TASK:");
			string KeyTask = Console.ReadLine();
			return KeyTask;
		}

		public string addTaskDecription()
		{
			Console.WriteLine("----------------------------------------------------------");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("DESCRIPTION:");
			Console.WriteLine();
			string DesValue = Console.ReadLine();
			return DesValue;
		}
		public void AddIntoList()
		{
			string key = addTask();
			string value = addTaskDecription();
			KeyVAluePair ref1 = classObj();
			tasklist.Add( ref1 );
		}


		public void removeTask()
		{
			Console.WriteLine("Enter the Task you want to remove");
			String removeVal = Console.ReadLine();
			KeyVAluePair OBJ = tasklist.Find(t => t.Key == removeVal);

			if(OBJ != null) //Contains -> checks if value is present in the list or not 
			{
				tasklist.Remove(OBJ);
			}
			else
			{
				Console.WriteLine($"given string '{OBJ.Key}' is not in the current Task Log ");
			}
		}


		public void DisplayTask()
		{
			DateTime date = DateTime.Now;
			
			foreach (var str in tasklist)
			{
				Console.WriteLine(string.Format($" Added Task :{str.Key} on ({date}) \n\n Description: \n {str.Value}"));
			}
			
		}



	}
	internal class ToDoList
	{
		static void Main(String[] args)
		{

			Task task = new Task();
			int var = Convert.ToInt32(Console.ReadLine());

			while(true)
			{

				switch (var)
				{
					case 1:
						task.AddIntoList();
						break;
					case 2:
						task.removeTask();
						break;
					case 3:
						task.DisplayTask();
						break;
					case 4:
						Environment.Exit(0);
						break;

					default:
						Console.WriteLine("Enter value is not correct");
						break;
				}
			}

			
		}
	}
}
