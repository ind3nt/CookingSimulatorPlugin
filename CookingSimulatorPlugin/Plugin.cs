using System;
using CookingSimulatorPlugin.API.Features.Products;
using CookingSimulatorPlugin.Events;
using Exiled.API.Features;

namespace CookingSimulatorPlugin
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;

        public static Product[] productsInstances;

        public override string Author => "sky3z";

        public override string Name => "CookingSimulatorPlugin";

        public override string Prefix => "CookingSimulatorPlugin";

        public static PlayersStorage Storage { get; private set; }

        public override Version Version => base.Version;

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
            Storage = new PlayersStorage();
            productsInstances = new Product[] { new Patty() };

            Exiled.Events.Handlers.Player.SearchingPickup += PlayerEvents.OnInteract;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Player.SearchingPickup -= PlayerEvents.OnInteract;
        }
    }
}
