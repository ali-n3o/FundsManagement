namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetDonationItems() {
        for (int i = 1; i <= 100; i++) {
            yield return $"Donation Item {i:D3}";
        }
    }
}