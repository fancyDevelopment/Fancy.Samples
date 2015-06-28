using System;

namespace Fancy.HelloDnx.App
{
	public class Program
	{
		public static void Main()
		{	
			string helloDnxString = CreateHelloDnxString();
			Console.WriteLine(helloDnxString);
		}
		
		public static string CreateHelloDnxString()
		{
			return "Hello DNX!";
		}
	}
}