using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Fancy.HelloMvc
{
	[Route("api/[controller]")]
    public class ValuesController : Controller
    {
		private ValuesContext _dbContext;
		
		public ValuesController(ValuesContext dbContext)
		{
			_dbContext = dbContext;
		}
		
		[HttpGet]
        public IEnumerable<Value> Get()
        {
            using(ValuesContext valuesContext = new ValuesContext())
			{
				return _dbContext.Values.ToList();
			}
        }
		
		[HttpPost]
        public int Post(string val)
        {
            using(ValuesContext valuesContext = new ValuesContext())
			{
				Value value = new Value() { Val = val };
				_dbContext.Values.Add(value);
				_dbContext.SaveChanges();
				return value.Id;
			}
        }
    }
}