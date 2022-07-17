namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetThemes() {
        yield return "Child Welfare";
        yield return "Education";
        yield return "Food Security";
        yield return "Health";
        yield return "Livelihoods";
        yield return "WASH";
    }
}