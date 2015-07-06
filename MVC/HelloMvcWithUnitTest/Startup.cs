using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace Fancy.HelloMvc
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseErrorPage();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

			// If no route matches show welcome page
            app.UseWelcomePage();
        }
	}
}