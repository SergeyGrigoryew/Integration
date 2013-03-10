using System;
using System.Collections.Generic;
using System.Text;

namespace Integration
{
	class Program
	{
		static void Main(string[] args)
		{
			string name;

			Console.WriteLine("Hello, User!");
			Console.Write("Your name: ");

			name  = Console.ReadLine();

			Console.WriteLine("Hello, {0}!", name);

			Console.ReadKey();
		}
	}
}
