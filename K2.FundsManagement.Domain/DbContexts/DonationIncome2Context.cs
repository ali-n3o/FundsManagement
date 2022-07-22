using K2.FundsManagement.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace K2.FundsManagement.Domain.DbContexts; 

public class DonationIncome2Context : DbContext
{
    public DonationIncome2Context (DbContextOptions<DonationIncome2Context> options)
        : base(options)
    {}

    public DbSet<DonationIncome2> DonationIncome { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<DonationIncome2>()
                    .ToTable("DonationIncome");

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