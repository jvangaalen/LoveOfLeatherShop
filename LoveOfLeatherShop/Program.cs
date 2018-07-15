using System.Linq;
using System;
using System.Data.Entity;



namespace LoveOfLeatherShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                // Create and save a new Item Table

                var keyChains = context.KeyChains
                        .Include(kc => kc.Color)
                        .Include(kc => kc.EndType)
                        .Include(kc => kc.Engraved)
                        .ToList();

                foreach (var keyChain in keyChains)
                {
                    Console.WriteLine(keyChain.DisplayText);
                }

                Console.ReadLine();
            }
        }
    }
}
   