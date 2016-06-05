using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAplikacija.Models
{
    public class ObjekatDbContext : DbContext
    {
        public DbSet<Vlasnik> Vlasniici { get; set; }
        public DbSet<Objekat> Objekti { get; set; }

        //za onemogucavanje automatskog dodavanja mnozine
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}