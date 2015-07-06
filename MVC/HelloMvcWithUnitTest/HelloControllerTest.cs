using System;
using Xunit;

namespace Fancy.HelloMvc
{
    public class HelloControllerTest
    {
		[Fact]
        public void GetTest()
        {
            HelloController target = new HelloController();
			
			Assert.Equal("Hello Mvc on Dnx!", target.Get());
        }
    }
}