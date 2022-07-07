using NodaTime;
using System.Diagnostics.CodeAnalysis;

namespace K2.FundsManagement.Abstractions.Models; 

public class DonationIncome {
    public int ID { get; set; }
    
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Theme { get; set; }
    public string Stipulation { get; set; }
    
    public string DonationItem { get; set; }

    public string AllocationType { get; set; }
    
    public int Beneficiary { get; set; }
    public int Project { get; set; }
    
    public int Amount { get; set; }
    public int Admin { get; set; }
    public int FundRaising { get; set; }
    public int ProjectSupport { get; set; }
    public int Reserves { get; set; }
    
    public int Balance { get; set; }
}