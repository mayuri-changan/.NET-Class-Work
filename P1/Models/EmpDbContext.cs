
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace P1.Models
{
    public class EmpDbContext : DbContext

    {
        public DbSet<Emp>Emps { get; set; }
        public EmpDbContext(DbContextOptions options):base(options)
        {
        }       
    }   
        
    
}
