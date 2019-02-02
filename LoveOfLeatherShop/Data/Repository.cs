using LoveOfLeatherShop.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LoveOfLeatherShop.DAL
{
    // Repository class. Provides datbase queries 
    // and CRUD operations.

    public static class Repository
    {
        static Context GetContext()
        {
            // Returns database context.

            var context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }

        // Returns a count of keychains.

        public static int GetKeyChainCount()
        {
            using (Context context = GetContext())
            {
                return context.KeyChains.Count();
            }
        }

        // Returns an Ilist of KeyChain entity instances.

        public static IList<KeyChain> GetKeyChains()
        {
            using (Context context = GetContext())
            {
                return context.KeyChains
                    .Include(kc => kc.Color)
                    .Include(kc => kc.EndType)
                    .Include(kc => kc.Engraved)
                    .ToList();
            }
        }

        // Returns single KeyChain.

        public static KeyChain GetKeyChain(int keyChainId)
        {
            using (Context context = GetContext())
            {
                return context.KeyChains
                    .Include(kc => kc.Color)
                    .Include(kc => kc.EndType)
                    .Include(kc => kc.Engraved)
                    .Where(kc => kc.Id == keyChainId)
                    .SingleOrDefault();
            }
        }

        // Add a key chain.

        public static void AddKeyChain(KeyChain keyChain)
        {
            // Add 
        }

        // Updates a key chain.

        public static void UpdateKeychain(KeyChain keyChain)
        {
            // Update
        }

        // Deletes a key chain.

        public static void DeleteKeyChain(int keyChainId)
        {
            // Delete
        }

    }
}