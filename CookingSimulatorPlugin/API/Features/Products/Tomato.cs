using System;
using CookingSimulatorPlugin.API.Features.Products.Enums;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public class Tomato : Product
    {
        public override ProductType Type => ProductType.Tomato;

        public override string Name => "Помидор";

        public override Ingredient[] Ingredients => Array.Empty<Ingredient>();

        public override bool CanBeSliced => true;

        public override bool CanBeFryed => false;

        public override void Create(Player player) { }
    }
}
