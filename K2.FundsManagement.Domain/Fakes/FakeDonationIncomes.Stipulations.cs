namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetStipulations() {
        yield return "Sadaqah";
        yield return "Zakat";
        yield return "Sadaqah Jariya";
    }
}