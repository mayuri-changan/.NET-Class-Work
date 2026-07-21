
using Microsoft.EntityFrameworkCore;
using Q8_ReactFrontEnd.Models;


namespace Q8_ReactFrontEnd.Models
{
    
        public class AppDbContext : DbContext
        {

            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {

            }


            public DbSet<Employee> Employees { get; set; }

        }
    }
