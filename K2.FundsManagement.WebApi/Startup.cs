using Autofac;
using K2.FundsManagement.Domain;
using Karakoram.Framework.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using K2.FundsManagement.Domain.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace K2.FundsManagement.WebApi; 

public class Startup : WebStartup {
    public override void ConfigureContainer(IConfiguration configuration, IHostEnvironment hostingEnvironment, ContainerBuilder builder) {
        builder.RegisterModule(new Registeration(configuration));
    }

    public override void ConfigureServices(IConfiguration configuration, IWebHostEnvironment hostingEnvironment, IServiceCollection services) {
        services.AddDbContext<DonationIncomeContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DonationIncomeContext")));
        
        services.AddDbContext<DonationIncome2Context>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DonationIncome2Context")));
    }

    public override void Configure(IConfiguration configuration, IWebHostEnvironment hostingEnvironment, IApplicationBuilder app) {
        // using var scope = app.ApplicationServices.CreateScope();
        // var services = scope.ServiceProvider;
        //
        // var context = services.GetRequiredService<DonationIncomeContext>();
        // context.Database.EnsureCreated();
        //DbInitializer.Initialize(context);
    }
}