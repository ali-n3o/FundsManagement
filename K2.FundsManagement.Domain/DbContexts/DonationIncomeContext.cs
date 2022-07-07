using K2.FundsManagement.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace K2.FundsManagement.Domain.DbContexts; 

public class DonationIncomeContext : DbContext
{
    public DonationIncomeContext (DbContextOptions<DonationIncomeContext> options)
        : base(options)
    {}

    public DbSet<DonationIncome> DonationIncome { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DonationIncome>().ToTable("DonationIncome");
    }
}