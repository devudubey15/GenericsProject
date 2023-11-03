using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
	class massage
	{
		public string GetMessage()
		{
			return string.Format($"this the message from {} to inform about these scenarios");
		}
		public string Email()
		{
			return string.Format($"email from1 '{}@mail.com' to '{}@mail.com' ");
		}
	}

	delegate void delfunc();
	class Program
	{

	}
	internal class GenericEventAndDelegate
	{
	}
}
