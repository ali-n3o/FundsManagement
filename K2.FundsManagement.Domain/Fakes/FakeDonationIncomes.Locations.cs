namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetLocations() {
        yield return "Afghanistan";
        yield return "Africa";
        yield return "Algeria";
        yield return "Bangladesh";
        yield return "India";
        yield return "Indonesia";
        yield return "Morocco";
        yield return "Pakistan";
        yield return "Somalia ";
        yield return "Sudan";
        yield return "Yemen";
    }
}