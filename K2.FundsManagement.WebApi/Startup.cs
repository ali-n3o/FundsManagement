using Karakoram.Framework.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace K2.FundsManagement.WebApi; 

public class Startup : WebStartup {
    public override void ConfigureServices(IConfiguration configuration, IWebHostEnvironment hostingEnvironment, IServiceCollection services) {
        base.ConfigureServices(configuration, hostingEnvironment, services);
    }
}