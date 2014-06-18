using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using My2AccountsInAGlance.Model;

namespace My2AccountsInAGlance.Repository
{
    
    public class My2AccountsInAGlance : DbContext
    {
        //http://finance.google.com/finance/info?client=ig&q=AAPL,YHOO
        string url = @"http://finance.google.com/finance/info?client=ig&q=MSFT";    //http://www.google.com/ig/api?stock=MSFT

        public DbSet<BrokerageAccount> BrokerageAccounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<MarketIndex> MarketIndexes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<MutualFund> MutualFunds { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // inherited table types
            // Map these class names to the table names in the DB
            modelBuilder.Entity<Security>().ToTable("Securities");
            modelBuilder.Entity<Stock>().ToTable("Securities_Stock");
            modelBuilder.Entity<MutualFund>().ToTable("Securities_MutualFund");

            // Many to many resolver
            // Map the WatchList and Securities navigation property using the WatchListSecurity Many-to-Many table.
            // To avoid a Cycle condition, WatchList has Securities, but Security does not have WatchLists.
            modelBuilder.Entity<WatchList>().HasMany(w => w.Securities).WithMany().Map(map => map.ToTable("WatchListSecurity").MapRightKey("SecurityId").MapLeftKey("WatchListId"));

        }

        public int DeleteAccounts()
        {
            return base.Database.ExecuteSqlCommand("DeleteAccounts");

        }

        public int DeleteSecuritiesAndExchanges()
        {
            return base.Database.ExecuteSqlCommand("DeleteSecuritiesAndExchanges");
        }
    }
}
