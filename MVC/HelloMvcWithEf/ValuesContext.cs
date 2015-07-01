using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Framework.ConfigurationModel;

namespace Fancy.HelloMvc
{
	public class ValuesContext : DbContext
    {
		private string _connectionString;
	
		public ValuesContext()
		{
			// Read the configuration
			IConfiguration configuration = new Configuration().AddJsonFile("config.json");
			
			// Read the connection string from the configuration
			_connectionString = configuration.Get("Data:DefaultConnection:ConnectionString");
		}
        public DbSet<Value> Values { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}