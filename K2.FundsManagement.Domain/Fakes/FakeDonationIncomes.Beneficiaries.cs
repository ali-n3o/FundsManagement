namespace K2.FundsManagement.Domain.Fakes; 

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetBeneficiaries() {
        for (int i = 1; i <= 100; i++) {
            yield return $"Beneficiary {i:D3}";
        }
    }
}