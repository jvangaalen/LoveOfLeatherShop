using System;
using System.Data.Entity;
using LoveOfLeatherShop.Models;

namespace LoveOfLeatherShop.DAL
{
    //Database initializer class used to populate database with seed data.

    internal class DataBaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            // Seed data...four key chains.

            var keychainOrder1 = new KeyChain()
            {
                Color = "Light Brown",
                EndType = "Flagged",
                Engraved = "This is my first key chain. "
            };
            var keyChainOrder2 = new KeyChain()
            {
                Color = "Dark Brown",
                EndType = "Rounded",
                Engraved = "This is my second key chain. "
            };
            var keyChainOrder = new KeyChain()
            {
                Color = "Light Brown",
                EndType = "Flagged",
                Engraved = "This is my favorite key chain. "
            };
            var keychainOrder4 = new KeyChain()
            {
                Color = "Dark Brown",
                EndType = "Rounded",
                Engraved = "This is my fourth and final keychain in the seed method. "
            };

            context.SaveChanges();
            //base.Seed(context);
        }  
    }
}