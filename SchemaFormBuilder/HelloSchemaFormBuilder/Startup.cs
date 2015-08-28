using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace Fancy.Samples.HelloSchemaFormBuilder
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add mvc to the ioc container
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Add mvc to the pipeline
            app.UseMvc();
        }
    }
}
