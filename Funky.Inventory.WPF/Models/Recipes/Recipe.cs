using Funky.Inventory.WPF.Models.Recipes.Enums;

namespace Funky.Inventory.WPF.Models.Recipes;

public class Recipe
{
    public Guid RecipeId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public RecipeType? Type { get; set; }
    public int? Score { get; set; }
}
