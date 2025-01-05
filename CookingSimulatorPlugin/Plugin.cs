using System;
using CookingSimulatorPlugin.API.Features.Products;
using CookingSimulatorPlugin.Events;
using Exiled.API.Features;

namespace CookingSimulatorPlugin
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public static PlayersStorage Storage { get; private set; }

        public override string Author => "sky3z";

        public override string Name => "CookingSimulatorPlugin";

        public override string Prefix => "CookingSimulatorPlugin";

        public override Version Version => base.Version;

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
            Storage = new PlayersStorage();

            Exiled.Events.Handlers.Player.SearchingPickup += PlayerEvents.OnInteract;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Player.SearchingPickup -= PlayerEvents.OnInteract;
        }
    }
}
