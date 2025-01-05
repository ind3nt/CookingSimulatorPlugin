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

                case "TakeApple":
                    if (!Plugin.Storage.Add(ev.Player, new Apple()))
                    {
                        ev.Player.Broadcast(3, $"Яблоко уже имеется у вас в инвентаре!", Broadcast.BroadcastFlags.Normal, true);
                        break;
                    }
                    ev.Player.Broadcast(3, $"Вы взяли яблоко!", Broadcast.BroadcastFlags.Normal, true);
                    break;

                case "TakeLettuce":
                    if (!Plugin.Storage.Add(ev.Player, new Lettuce()))
                    {
                        ev.Player.Broadcast(3, $"Лист салата уже имеется у вас в инвентаре!", Broadcast.BroadcastFlags.Normal, true);
                        break;
                    }
                    ev.Player.Broadcast(3, $"Вы взяли лист салата!", Broadcast.BroadcastFlags.Normal, true);
                    break;

                case "TakeOliveOil":
                    if (!Plugin.Storage.Add(ev.Player, new OliveOil()))
                    {
                        ev.Player.Broadcast(3, $"Оливковое масло уже имеется у вас в инвентаре!", Broadcast.BroadcastFlags.Normal, true);
                        break;
                    }
                    ev.Player.Broadcast(3, $"Вы взяли оливковое масло!", Broadcast.BroadcastFlags.Normal, true);
                    break;

                case "TakeTomato":
                    if (!Plugin.Storage.Add(ev.Player, new Tomato()))
                    {
                        ev.Player.Broadcast(3, $"Помидор уже имеется у вас в инвентаре!", Broadcast.BroadcastFlags.Normal, true);
                        break;
                    }
                    ev.Player.Broadcast(3, $"Вы взяли помидор!", Broadcast.BroadcastFlags.Normal, true);
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
