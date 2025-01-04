using CookingSimulatorPlugin.API.Features.Products.Enums;

namespace CookingSimulatorPlugin.API.Features.Products
{
    public class Ingredient
    {
        public ProductType Type { get; set; }

        public bool IsFryedRequired { get; set; }

        public bool IsSliceRequired { get; set; }

        public Ingredient(ProductType Type, bool IsFryedRequired, bool IsSliceRequired)
        {
            this.Type = Type;
            this.IsFryedRequired = IsFryedRequired;
            this.IsSliceRequired = IsSliceRequired;
        }
    }
}
