using System;
using System.Collections.Generic;
using System.Text;

namespace Integration
{
	class User
	{
		private string Name;
		private string Email;
		
		public User(string name, string email)
		{
			Name = name;
			Email = email;
		}

		public override string ToString()
		{
			return "User name:\t" + Name + "\nUser email:\t" + Email;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			string name;
			string email;

			Console.WriteLine("Enter your name");
			name = Console.ReadLine();

			Console.WriteLine("Enter your email");
			email = Console.ReadLine();

			User user = new User(name, email);
			Console.WriteLine(user.ToString());
		}
	}
}
