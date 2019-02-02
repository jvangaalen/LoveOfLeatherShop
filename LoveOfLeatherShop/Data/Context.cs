using LoveOfLeatherShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LoveOfLeatherShop.DAL
{
    //Entity FrameWork context class.

    public class Context : DbContext
    {


        public Context() : base("Context")
        {
            // configure EF to use DatabaseInitializer class to seed our data.
            Database.SetInitializer(new DataBaseInitializer());
        }

        public DbSet<KeyChain> KeyChains { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}