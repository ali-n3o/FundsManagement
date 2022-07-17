namespace K2.FundsManagement.Domain.Fakes;

public partial class FakeDonationIncomes {
    private IEnumerable<string> GetAllocationTypes() {
        yield return AllocationTypes.Fund;
        yield return AllocationTypes.Sponsorship;
        yield return AllocationTypes.Feedback;
        yield return AllocationTypes.Project;
    }
}

public static class AllocationTypes {
    public const string Fund = nameof(Fund);
    public const string Sponsorship = nameof(Sponsorship);
    public const string Feedback = nameof(Feedback);
    public const string Project = nameof(Project);
}