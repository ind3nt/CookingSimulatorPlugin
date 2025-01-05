using System;
using CommandSystem;
using CookingSimulatorPlugin.API.Features.Products;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.Commands
{
    class GetInventory
    {
        [CommandHandler(typeof(RemoteAdminCommandHandler))]
        [CommandHandler(typeof(ClientCommandHandler))]
        public class CheckInventoryCommand : ICommand
        {
            public string Command => "checkinventory";

            public string[] Aliases { get; } = { };

            public string Description => "Бургер";

            public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
            {
                Player player = Player.Get(sender);

                if (!player.IsAlive)
                {
                    response = "Вы не можете использовать эту команду, будучи мертвым!";
                    return false;
                }

                Product[] playerProducts = Utilities.GetInventory(player);

                if (playerProducts == null)
                {
                    response = "Ваш инвентарь пуст!";
                    return false;
                }

                string message = "\nИнгредиенты в инвентаре:\n";

                foreach (Product product in playerProducts)
                {
                    message = message + $"- {product.Name}\n";
                }
                    
                response = message;
                return true;
            }
        }
    }
}
