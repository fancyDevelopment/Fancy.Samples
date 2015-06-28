using Fancy.HelloDnx.App;
using Xunit;

namespace HelloDnx.Tests
{
	public class ProgramTests
	{		
		[Fact]
		public void CreateHelloDnxStringTest()
		{
			Assert.Equal("Hello DNX!", Program.CreateHelloDnxString());
		}
	}
}