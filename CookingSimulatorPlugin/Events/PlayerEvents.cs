using CookingSimulatorPlugin.API.Features.Products;
using Exiled.Events.EventArgs.Player;

namespace CookingSimulatorPlugin.Events
{
    class PlayerEvents
    {
        public static void OnInteract(SearchingPickupEventArgs ev)
        {
            switch (ev.Pickup.GameObject.name)
            {
                case "TakePatty":
                    if (!Plugin.Storage.Add(ev.Player, new Patty()))
                    {
                        ev.Player.Broadcast(3, $"Котлета уже имеется у вас в инвентаре!", Broadcast.BroadcastFlags.Normal, true);
                        break;
                    }
                    ev.Player.Broadcast(3, $"Вы взяли котлету!", Broadcast.BroadcastFlags.Normal, true);
                    break;

                case "TakeBun":
                    if (!Plugin.Storage.Add(ev.Player, new Bun()))
                    {
                        ev.Player.Broadcast(3, $"Булка уже имеется у вас в инвентаре!", Broadcast.BroadcastFlags.Normal, true);
                        break;
                    }
                    ev.Player.Broadcast(3, $"Вы взяли булку!", Broadcast.BroadcastFlags.Normal, true);
                    break;

                case "FryPickup":
                    Plugin.Storage.Fry(ev.Player);
                    break;

                case "SlicePickup":
                    Plugin.Storage.Slice(ev.Player);
                    break;
            }
        }
    }
}
