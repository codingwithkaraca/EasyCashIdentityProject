using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentityProject.DataAccessLayer.Context;

public class EasyCashIdentityContext : IdentityDbContext
{
    public EasyCashIdentityContext(DbContextOptions<EasyCashIdentityContext> options) : base(options)
    {
    }
    
    // buraya DBSetler gelecek
    
}