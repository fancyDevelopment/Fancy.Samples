using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Fancy.HelloMvc
{
	[Route("api/[controller]")]
    public class ValuesController : Controller
    {
		[HttpGet]
        public IEnumerable<Value> Get()
        {
            using(ValuesContext valuesContext = new ValuesContext())
			{
				return valuesContext.Values.ToList();
			}
        }
		
		[HttpPost]
        public int Post(string val)
        {
            using(ValuesContext valuesContext = new ValuesContext())
			{
				Value value = new Value() { Val = val };
				valuesContext.Values.Add(value);
				valuesContext.SaveChanges();
				return value.Id;
			}
        }
    }
}