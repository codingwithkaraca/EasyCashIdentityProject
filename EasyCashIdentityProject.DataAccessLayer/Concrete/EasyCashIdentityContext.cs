using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete;

public class EasyCashIdentityContext : IdentityDbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433; Database=EasyCashIdentityDB; User Id=sa; Password=macbook/M2Air; TrustServerCertificate=True;");
    }
    
    public DbSet<CustomerAccount> CustomerAccounts { get; set; }
    public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
    
}