using System;
using CommandSystem;
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

                string message = Plugin.Storage.GetInventory(player);

                if (message == null)
                {
                    response = "Ваш инвентарь пуст!";
                    return false;
                }
                    
                response = Plugin.Storage.GetInventory(player);
                return true;
            }
        }
    }
}
