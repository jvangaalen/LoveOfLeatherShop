using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using LoveOfLeatherShop.Models;

namespace LoveOfLeatherShop
{
     class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ItemContext())
            {
                // Create and save a new Item Table
                Console.Write("Enter a new Item into the cart. ");
                var name = Console.ReadLine();

                var item = new Item { Name = name };
                db.Items.Add(item);
                db.SaveChanges();

                // Dislpay all Items from the database
                var query = from i in db.Items
                            orderby i.Name
                            select i;

                Console.WriteLine("All items in the database: ");
                foreach (var product in query)
                {
                    Console.WriteLine(product.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Bracelet> Bracelets { get; set; }
        public DbSet<HandBag> HandBags { get; set; }
        public DbSet<KeyChain> KeyChains { get; set; }
    }
}