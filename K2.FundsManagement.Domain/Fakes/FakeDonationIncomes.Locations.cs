namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetLocations() {
        yield return "Pakistan";
        yield return "Bangladesh";
        yield return "India";
    }
}