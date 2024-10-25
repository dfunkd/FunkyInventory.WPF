using Funky.Inventory.WPF.Models.Recipes.Enums;

namespace Funky.Inventory.WPF.Models.Recipes;

public class Recipe
{
    public Guid RecipeId { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    public string? Description { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public string? Tips { get; set; }
    public string? Url { get; set; }

    public int? CookTime { get; set; }
    public int? PrepTime { get; set; }
    public int? Servings { get; set; }
    public int? Score { get; set; }
    public int? TotalTime 
        => CookTime ?? 0 + PrepTime ?? 0;

    public RecipeType? Type { get; set; }

    public List<MILink> Ingredients { get; set; }
}
