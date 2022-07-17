namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetProjects() {
        for (int i = 1; i <= 100; i++) {
            yield return $"Project {i:D3}";
        }
    }
}