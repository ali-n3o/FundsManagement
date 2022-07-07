using Autofac;
using Karakoram.Faker;
using Karakoram.Framework.Autofac;
using Microsoft.Extensions.Configuration;

namespace K2.FundsManagement.Domain; 

public class Registeration : AutofacModule {
    public Registeration(IConfiguration configuration) : base(configuration) { }
    
    protected override void Configure(ContainerBuilder builder) {
        builder.RegisterModule(new FakerRegistration(Configuration));
    }
}