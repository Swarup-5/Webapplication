using Microsoft.EntityFrameworkCore;
using Webapplication.Data.Entity;

namespace Webapplication.Data.Context
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions options) : base(options)  
        
        {


        }
        public DbSet<User> User { get; set; } 
        public DbSet<Signuptable> signUps { get; set; } 

        public DbSet<Logintable> logintable { get; set; }

        public DbSet<Producttablecs> prod { get; set; }

    }
        
   
}
