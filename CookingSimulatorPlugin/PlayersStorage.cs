using System.Collections.Generic;
using System.Linq;
using CookingSimulatorPlugin.API.Features.Products;
using Exiled.API.Features;
using Utils.NonAllocLINQ;

namespace CookingSimulatorPlugin
{
    public class PlayersStorage
    {
        public static Dictionary<Player, List<Product>> playerProducts = new Dictionary<Player, List<Product>>();

        public bool Add(Player player, Product product)
        {
            if (!playerProducts.ContainsKey(player))
                playerProducts.Add(player, new List<Product>());

            if (playerProducts[player].Any(p => p.Type == product.Type))
                return false;

            playerProducts[player].Add(product);
            CheckCreate(player);
            return true;
        }

        public bool Remove(Player player, Product product)
        {
            if (!playerProducts.ContainsKey(player))
                return false;

            if (!playerProducts[player].Remove(product))
            {
                return false;
            }
            
            return true;
        } 

        public void CheckCreate(Player player)
        {
            foreach (Product product in CraftableProducts.Products)
            {
                if (product.IsCanCraft(playerProducts[player].ToArray()))
                {
                    product.Create(player);

                    foreach (Ingredient ingredient in product.Ingredients)
                    {
                        playerProducts[player].Remove(playerProducts[player].Find(item => item.Type == ingredient.Type));
                    }
                }
            }
        }

        public void Fry(Player player)
        {
            foreach (Product product in playerProducts[player])
            {
                if (product.CanBeFryed && !product.IsFryed)
                {
                    product.Fry();
                    player.Broadcast(2, $"Вы успешно пожарили {product.Name}!", Broadcast.BroadcastFlags.Normal, true);
                    CheckCreate(player);
                    return;
                }
            }
            
            player.Broadcast(2, "Вам нечего жарить!", Broadcast.BroadcastFlags.Normal, true);
        }

        public void Slice(Player player)
        {
            foreach (Product product in playerProducts[player])
            {
                if (product.CanBeSliced && !product.IsSliced)
                {
                    product.Slice();
                    player.Broadcast(2, $"Вы успешно порезали {product.Name}!", Broadcast.BroadcastFlags.Normal, true);
                    CheckCreate(player);
                    return;
                }
            }
            
            player.Broadcast(2, "Вам нечего резать!", Broadcast.BroadcastFlags.Normal, true);
        }
    }
}
