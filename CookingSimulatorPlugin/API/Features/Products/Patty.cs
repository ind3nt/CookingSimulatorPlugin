using System;
using CookingSimulatorPlugin.API.Features.Products.Enums;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public class Patty : Product
    {
        public override ProductType Type => ProductType.Patty;

        public override string Name => "Котлета";

        public override Ingredient[] Ingredients => Array.Empty<Ingredient>();

        public override bool CanBeSliced => false;

        public override bool CanBeFryed => true;

        public override void Create(Player player) { }
    }
}
