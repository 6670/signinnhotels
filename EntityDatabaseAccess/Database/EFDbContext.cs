using EntityDatabaseAccess.EntityObject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityDatabaseAccess.Database
{
    public class EFDbContext : DbContext
    {
       static EFDbContext()
        {
           
          // Database.SetInitializer<EFDbContext>(null);
        }
        public EFDbContext() : base("name=StydyCentreEntites")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
       public DbSet<Booking> Rooks { get; set; }
       public DbSet<Roome> Roomes { get; set; }
       public DbSet<RoomeDetail> RoomeDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


    }

    }
}