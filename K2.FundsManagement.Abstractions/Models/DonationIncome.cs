namespace K2.FundsManagement.Abstractions.Models; 

public class DonationIncome {
    public int ID { get; set; }
    
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Theme { get; set; }
    public string Stipulation { get; set; }
    
    public string DonationItem { get; set; }

    public string AllocationType { get; set; }
    
    public string Beneficiary { get; set; }
    public string Project { get; set; }
    
    public int Amount { get; set; }
    public double Admin { get; set; }
    public double FundRaising { get; set; }
    public double ProjectSupport { get; set; }
    public double Reserves { get; set; }
    
    public double Balance { get; set; }
}