using K2.FundsManagement.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace K2.FundsManagement.Domain.DbContexts; 

public class DonationIncomeContext : DbContext
{
    public DonationIncomeContext (DbContextOptions<DonationIncomeContext> options)
        : base(options)
    {}

    public DbSet<DonationIncome> DonationIncome { get; set; }
    public DbSet<DonationIncomeWithJoins> DonationIncomeWithJoins { get; set; }
    public DbSet<DonationIncomeWithCSIX> DonationIncomeWithCSIX { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DonationIncome>().ToTable("DonationIncome");
        
        modelBuilder.Entity<DonationIncomeWithJoins>()
                    .ToTable("DonationIncomeWithJoins");
        
        modelBuilder.Entity<DonationIncomeWithCSIX>()
                    .ToTable("DonationIncomeWithCSIX");

        modelBuilder.Entity<Location>()
                    .ToTable("DimLocation");

        modelBuilder.Entity<Theme>()
                    .ToTable("DimTheme");
        
        modelBuilder.Entity<Stipulation>()
                    .ToTable("DimStipulation");
        
        modelBuilder.Entity<DonationItem>()
                    .ToTable("DimDonationItem");
        
        modelBuilder.Entity<AllocationType>()
                    .ToTable("DimAllocationType");
        
        modelBuilder.Entity<Beneficiary>()
                    .ToTable("DimBeneficiary");
        
        modelBuilder.Entity<Project>()
                    .ToTable("DimProject");
    }
}