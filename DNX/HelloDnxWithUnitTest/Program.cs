using System;
using Xunit;

namespace Fancy.HelloDnxWithUnitTest
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
		
		[Fact]
		public void CreateHelloDnxStringTest()
		{
			Assert.Equal("Hello DNX!", CreateHelloDnxString());
		}
	}
}