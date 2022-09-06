using PR_1.Models;
using Microsoft.EntityFrameworkCore;


namespace PR_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        
            public ApplicationDbContext(
                DbContextOptions <ApplicationDbContext> options) : base(options)
            {
            }
            public DbSet <Category> Category { get; set; }
        
    }
}
