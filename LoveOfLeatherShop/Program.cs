using System.Linq;
using System;
using System.Data.Entity;
using LoveOfLeatherShop.Models;

namespace LoveOfLeatherShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                // Create and save a new Item Table

                context.KeyChains.Add(new KeyChain()
                {
                    Color = "Light Brown",
                    EndType = "Rounded",
                    Engraved = "This is a message."
                });
                context.SaveChanges();

                var keyChains = context.KeyChains.ToList();
                        //.Include(kc => kc.Color)
                       // .Include(kc => kc.EndType)
                       // .Include(kc => kc.Engraved)
                       // .ToList();

                foreach (var keyChain in keyChains)
                {
                    Console.WriteLine(keyChain.Engraved);
                }

                Console.ReadLine();
            }
        }
    }
}
   