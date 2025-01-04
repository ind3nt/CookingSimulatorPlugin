using System.Linq;
using CookingSimulatorPlugin.API.Features.Products.Enums;
using Exiled.API.Features;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public abstract class Product
    {
        public abstract ProductType Type { get; }

        public abstract string Name { get; }

        public abstract Ingredient[] Ingredients { get; }

        public abstract bool CanBeSliced { get; }

        public abstract bool CanBeFryed { get; }

        public bool IsSliced = false;

        public bool IsFryed = false;

        public abstract void Create(Player player);

        public bool IsCanCraft(Product[] playerIngredients)
        {
            int i = 0;

            foreach (var ingredient in playerIngredients)
            {

                foreach (var ingredientType in Ingredients)
                {
                    if (ingredientType.Type != ingredient.Type)
                    {
                        continue;
                    }

                    if (ingredientType.IsSliceRequired != ingredient.IsSliced)
                    {
                        continue;
                    }

                    if (ingredientType.IsFryedRequired != ingredient.IsFryed)
                    {
                        continue;
                    }

                    i++;
                }
            }

            if (i != Ingredients.Count())
            {
                return false;
            }

            return true;
        }

        public bool Slice()
        {
            if (!CanBeSliced)
                return false;

            if (IsSliced)
                return false;

            IsSliced = true;
            return true;
        }

        public bool Fry()
        {
            if (!CanBeFryed)
                return false;

            if (IsFryed)
                return false;

            IsFryed = true;
            return true;
        }
    }
}
