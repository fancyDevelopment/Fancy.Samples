using System;
using System.Linq;
using System.Reflection;

namespace Fancy.HelloDnx.Commands
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Assembly assembly = Assembly.Load(new AssemblyName(args[0]));
			
			int typeCount = assembly.GetTypes().Count();
			int methodCount = assembly.GetTypes().Aggregate(0, (count, type) => type.GetMethods().Count() + count);
				
			Console.WriteLine("Code Statistics for assembly " + assembly.GetName().Name);
			Console.WriteLine("Number of types in Assembly: " + typeCount);
			Console.WriteLine("Number of methods of types in Assembly: " + methodCount);
		}
	}
}