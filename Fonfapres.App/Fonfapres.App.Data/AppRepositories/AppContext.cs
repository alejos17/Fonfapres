using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Fonfapres.App.Domain;

namespace Fonfapres.App.Data
{
    public class AppContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<CashBox> CashBoxes { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source= 192.168.1.2; Initial Catalog =FonfapresBD;User Id=sa; Password=Alesan.2021");
            }
        }

    }
}