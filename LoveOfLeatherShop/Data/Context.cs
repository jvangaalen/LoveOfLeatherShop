using LoveOfLeatherShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LoveOfLeatherShop.DAL
{
    public class Context : DbContext
    {

        public Context() : base("Context")
        {
        }

        public DbSet<KeyChain> KeyChains { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}