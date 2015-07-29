using System;
using Microsoft.Data.Entity;

namespace Fancy.HelloMvc
{
	public class ValuesContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
    }
}