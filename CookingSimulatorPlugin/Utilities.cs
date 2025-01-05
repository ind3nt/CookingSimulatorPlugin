using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookingSimulatorPlugin.API.Features.Products;
using Exiled.API.Features;
using HarmonyLib;

namespace CookingSimulatorPlugin
{
    public class Utilities
    {
        static Dictionary<Player, List<Product>> playerProducts = PlayersStorage.playerProducts;

        public static Product[] GetInventory(Player player)
        {
            if (!playerProducts.ContainsKey(player))
                return null;

            if (playerProducts[player].Count <= 0)
                return null;

            List<Product> products = new List<Product>();

            foreach (Product product in playerProducts[player])
            {
                products.Add(product);
            }

            return products.ToArray();
        }
    }
}
