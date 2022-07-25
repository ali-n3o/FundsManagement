using System.ComponentModel.DataAnnotations.Schema;

namespace K2.FundsManagement.Abstractions.Models; 

public class DonationIncomeWithCSIX {
    public int ID { get; set; }
    
    public DateTime Date { get; set; }
    
    
    [ForeignKey("LocationId")]
    public Location Location { get; set; }
    public Int16 LocationId { get; set; }
    
    [ForeignKey("ThemeId")]
    public Theme Theme { get; set; }
    public Int16 ThemeId { get; set; }
    
    [ForeignKey("StipulationId")]
    public Stipulation Stipulation { get; set; }
    public Int16 StipulationId { get; set; }
    
    [ForeignKey("DonationItemId")]
    public DonationItem DonationItem { get; set; }
    public Int16 DonationItemId { get; set; }
    
    [ForeignKey("AllocationTypeId")]
    public AllocationType AllocationType { get; set; }
    public Int16 AllocationTypeId { get; set; }
    
    [ForeignKey("BeneficiaryId")]
    public Beneficiary Beneficiary { get; set; }
    public Int16? BeneficiaryId { get; set; }
    
    [ForeignKey("ProjectId")]
    public Project Project { get; set; }
    public Int16 ProjectId { get; set; }
    
    public int Amount { get; set; }
    public double Admin { get; set; }
    public double FundRaising { get; set; }
    public double ProjectSupport { get; set; }
    public double Reserves { get; set; }
    
    public double Balance { get; set; }
}