using Microsoft.EntityFrameworkCore;
using src.Models;

public class LoanRequestContext : DbContext
{
    public LoanRequestContext(DbContextOptions<LoanRequestContext> options) : base(options) { }

    public DbSet<LoanRequest> LoanRequests { get; set; }
}