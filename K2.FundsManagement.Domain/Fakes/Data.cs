namespace K2.FundsManagement.Domain.Fakes; 

public static class Data {
    public static IEnumerable<string> GetThemes() {
        yield return "Child Welfare";
        yield return "Education";
        yield return "Food Security";
        yield return "Health";
        yield return "Livelihoods";
        yield return "WASH";
    }
    
    public static IEnumerable<string> GetLocations() {
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
    
    public static IEnumerable<string> GetStipulations() {
        yield return "Sadaqah";
        yield return "Zakat";
        yield return "Sadaqah Jariya";
    }
    
    public static IEnumerable<string> GetAllocationTypes() {
        yield return AllocationTypes.Fund;
        yield return AllocationTypes.Sponsorship;
        yield return AllocationTypes.Feedback;
        yield return AllocationTypes.Project;
    }
    
    public static IEnumerable<string> GetBeneficiaries() {
        for (int i = 1; i <= 100; i++) {
            yield return $"Beneficiary {i:D3}";
        }
    }
    
    public static IEnumerable<string> GetDonationItems() {
        for (int i = 1; i <= 100; i++) {
            yield return $"Donation Item {i:D3}";
        }
    }
    
    public static IEnumerable<string> GetProjects() {
        for (int i = 1; i <= 100; i++) {
            yield return $"Project {i:D3}";
        }
    }
}

public static class AllocationTypes {
    public const string Fund = nameof(Fund);
    public const string Sponsorship = nameof(Sponsorship);
    public const string Feedback = nameof(Feedback);
    public const string Project = nameof(Project);
}