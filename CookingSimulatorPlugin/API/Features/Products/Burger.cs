using CookingSimulatorPlugin.API.Features.Products.Enums;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public class Burger : Product
    {
        public override ProductType Type => ProductType.Burger;

        public override string Name => "Бургер";

        public override Ingredient[] Ingredients { get; } = new[] 
        { 
            new Ingredient(ProductType.Patty, true, false), 
            new Ingredient(ProductType.Bun, false, true), 
            new Ingredient(ProductType.Tomato, false, true),
            new Ingredient(ProductType.Lettuce, false, true),
            new Ingredient(ProductType.Cheese, false, true)
        };

        public override bool CanBeSliced => false;

        public override bool CanBeFryed => true;

        public override void Create(Player player)
        {
            player.Broadcast(2, $"Вы успешно собрали {Name}!", Broadcast.BroadcastFlags.Normal, true);
        }
    }
}
