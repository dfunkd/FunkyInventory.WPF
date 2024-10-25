namespace Funky.Inventory.WPF.Models.Recipes;

public class MILink
{
    public Guid MeasurementId { get; set; }
    public Guid IngredientId { get; set; }
    public string? DisplayQuantity { get; set; }
    public decimal Quantity { get; set; }
}
