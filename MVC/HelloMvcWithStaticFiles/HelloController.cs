using System;
using Microsoft.AspNet.Mvc;

namespace Fancy.HelloMvc
{
	[Route("api/[controller]")]
    public class HelloController : Controller
    {
		[HttpGet]
        public string Get()
        {
            return "Hello Mvc on Dnx!";
        }
    }
}