using K2.FundsManagement.Abstractions.Models;
using Karakoram.Faker;

namespace K2.FundsManagement.Domain.Fakes; 

public class FakeDonationIncomes : FakeDataCollection<DonationIncome> {
    
    public override IEnumerable<DonationIncome> Generate() {

        Faker.RuleFor(x => x.Date, f => f.Date.Past(1).Date);

        Faker.RuleFor(x => x.Location, f => f.PickRandom(GetLocations()));
        Faker.RuleFor(x => x.Theme, f => f.PickRandom(GetThemes()));
        Faker.RuleFor(x => x.Stipulation, f => f.PickRandom(GetStipulations()));
        
        Faker.RuleFor(x => x.DonationItem, f => f.PickRandom(GetDonationItems()));

        Faker.RuleFor(x => x.AllocationType, f => f.PickRandom(GetAllocationTypes()));

        Faker.RuleFor(x => x.Amount, f => f.Random.Int(0, 1001));


        return Faker.Generate(100);
    }

    private IEnumerable<string> GetLocations() {
        yield return "Pakistan";
        yield return "Bangladesh";
        yield return "India";
    }

    private IEnumerable<string> GetThemes() {
        yield return "Child Welfare";
        yield return "Education";
        yield return "Food Security";
        yield return "Health";
        yield return "Livelihoods";
        yield return "WASH";
    }
    
    private IEnumerable<string> GetStipulations() {
        yield return "Sadaqah";
        yield return "Zakat";
        yield return "Sadaqah Jariya";
    }
    
    private IEnumerable<string> GetDonationItems() {
        yield return "Donation Item 001";
        yield return "Donation Item 002";
        yield return "Donation Item 003";
    }

    private IEnumerable<string> GetAllocationTypes() {
        yield return "Fund";
        yield return "Sponsorship";
        yield return "Feedback";
        yield return "Project";
    }
}