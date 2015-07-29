using Microsoft.AspNet.Builder;
using Microsoft.Framework.Runtime;
using Microsoft.Framework.Configuration;

using Microsoft.Framework.DependencyInjection;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace Fancy.HelloMvc
{
    public class Startup
    {	
       private string _connectionString;
                
       public Startup(IApplicationEnvironment appEnv)
       {
           // Read the configuration
           IConfiguration configuration = new ConfigurationBuilder(appEnv.ApplicationBasePath).AddJsonFile("config.json").Build();
        		
           // Read the connection string from the configuration
           _connectionString = configuration.Get("Data:DefaultConnection:ConnectionString");
       }    
                	
	   public void ConfigureServices(IServiceCollection services)
       {
           services.AddMvc();
            
           services.AddEntityFramework()
                   .AddSqlServer()
                   .AddDbContext<ValuesContext>(options => options.UseSqlServer(_connectionString));
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseErrorPage();
        
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        
            app.UseWelcomePage();
        }
    }
}