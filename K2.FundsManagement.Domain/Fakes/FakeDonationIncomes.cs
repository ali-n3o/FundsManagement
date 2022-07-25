using K2.FundsManagement.Abstractions.Models;
using Karakoram.Faker;

namespace K2.FundsManagement.Domain.Fakes; 

public class FakeDonationIncomes : FakeDataCollection<DonationIncome> {
    
    public override IEnumerable<DonationIncome> Generate() {

        Faker.RuleFor(x => x.Date, f => f.Date.Past(1).Date);

        Faker.RuleFor(x => x.Location, f => f.PickRandom(Data.GetLocations()));
        Faker.RuleFor(x => x.Theme, f => f.PickRandom(Data.GetThemes()));
        Faker.RuleFor(x => x.Stipulation, f => f.PickRandom(Data.GetStipulations()));
        
        Faker.RuleFor(x => x.DonationItem, f => f.PickRandom(Data.GetDonationItems()));

        Faker.RuleFor(x => x.AllocationType, f => f.PickRandom(Data.GetAllocationTypes()));

        Faker.RuleFor(x => x.Beneficiary, (f, di) => {
            if (di.AllocationType == AllocationTypes.Sponsorship) {
                return f.PickRandom(Data.GetBeneficiaries());
            }
            return string.Empty;
        });
        Faker.RuleFor(x => x.Project, (f, di) => {
            if (di.AllocationType == AllocationTypes.Project) {
                return f.PickRandom(Data.GetProjects());
            }
            return string.Empty;
        });
        

        Faker.RuleFor(x => x.Amount, f => f.Random.Int(0, 1001));
        Faker.RuleFor(x => x.Admin, (f, di) => {
            
            if (di.AllocationType == AllocationTypes.Sponsorship) {
                return -di.Amount * 0.1;
            } else {
                return -di.Amount * 0.1;
            }
        });
        
        Faker.RuleFor(x => x.FundRaising, (_, di) =>  -di.Amount * 0.02);
        Faker.RuleFor(x => x.ProjectSupport, (f, di) => {
            if (di.AllocationType == AllocationTypes.Project) {
                return -di.Amount * 0.3;
            }
            return 0;
        });
        Faker.RuleFor(x => x.Reserves, (f, di) => -di.Amount*0.02);

        Faker.RuleFor(x => x.Balance, (f, di) =>  di.Amount - di.Admin - di.FundRaising - di.ProjectSupport - di.Reserves);
        


        return Faker.Generate(500);
    }
}