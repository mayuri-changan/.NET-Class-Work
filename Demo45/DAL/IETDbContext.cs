using System.Reflection.Metadata;
using Demo45.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Configuration;

namespace Demo45.DAL
{
    public class IETDbContext : DbContext
    //{
    //    public DbSet<Emp> emps { get; set; }


    //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        var builder = new ConfigurationBuilder();

    //        builder.SetBasePath(Directory.GetCurrentDirectory());

    //        builder.AddJsonFile("appsettings.json");

    //        IConfiguration config = builder.Build();

    //        optionsBuilder.UseSqlServer(config.GetConnectionString("conStr"));
    //    }
    //}
    {    
            public DbSet<Emp> emps {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           var builder= new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings");
           IConfiguration config= builder.Build();
           optionsBuilder.UseSqlServer (config.GetConnectionString(""));
        }


    
    
    }
}

