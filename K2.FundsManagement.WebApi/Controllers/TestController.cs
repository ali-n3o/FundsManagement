using Autofac;
using K2.FundsManagement.Abstractions.Models;
using K2.FundsManagement.Domain.DbContexts;
using Karakoram.Faker;
using Karakoram.Framework.Web;
using Karakoram.Framework.Web.Swagger;
using Microsoft.AspNetCore.Mvc;

namespace K2.FundsManagement.WebApi.Controllers; 

[ApiVersion("1.0")]
[Swagger("Test")]
public class TestController : DefaultApiController {
    private readonly IComponentContext _componentContext;

    public TestController(IComponentContext componentContext) : base(componentContext) {
        _componentContext = componentContext;
    }

    [HttpPost("InsertData")]
    public ActionResult InsertData() {
        var context = _componentContext.Resolve<DonationIncomeContext>();
        var faker = _componentContext.Resolve<IFakeDataCollection<DonationIncome>>();

        for (int i = 0; i < 10000; i++) {
            var items = faker.Generate();
            context.DonationIncome.AddRange(items);
            context.SaveChanges();
        }
        
        return Ok();
    }
    
}