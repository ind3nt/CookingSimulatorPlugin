using System;
using CookingSimulatorPlugin.API.Features.Products.Enums;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public class OliveOil : Product
    {
        public override ProductType Type => ProductType.OliveOil;

        public override string Name => "Оливковое масло";

        public override Ingredient[] Ingredients => Array.Empty<Ingredient>();

        public override bool CanBeSliced => false;

        public override bool CanBeFryed => false;

        public override void Create(Player player) { }
    }
}
