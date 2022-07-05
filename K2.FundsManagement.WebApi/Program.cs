using K2.FundsManagement.WebApi;
using Karakoram.Framework.Startup;
using Karakoram.Framework.Web;

namespace K2.Accounts.WebApi;

public class Program {
    public static async Task Main(string[] args) {
        await ServiceHost.Create<Startup>(args)
                         .ForWeb()
                         .RunAsync();
    }
}