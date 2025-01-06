using System;
using CookingSimulatorPlugin.API.Features.Products.Enums;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public class Salad : Product
    {
        public override ProductType Type => ProductType.Salad;

        public override string Name => "Салат";

        public override Ingredient[] Ingredients { get; } = new[]
        { 
            new Ingredient(ProductType.Apple, false, true), 
            new Ingredient(ProductType.Lettuce, false, true), 
            new Ingredient(ProductType.OliveOil, false, false),
            new Ingredient(ProductType.Tomato, false, true)
        };

        public override bool CanBeSliced => false;

        public override bool CanBeFryed => true;

        public override void Create(Player player)
        {
            player.Broadcast(2, "Вы собрали салат!", Broadcast.BroadcastFlags.Normal, true);
        }
    }
}
