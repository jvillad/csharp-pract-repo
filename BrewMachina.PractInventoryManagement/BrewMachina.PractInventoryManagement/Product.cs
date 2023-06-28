namespace BrewMachina.PractInventoryManagement;

public class Product
{
    private int id;
    private string name = null!;
    private string? description;

    private int maxItemsInStock = 0;
    private UnitType unitType;
    // a true or false to check if the item stock is below a given threshold
    // defaulting to false
    private bool isBelowStockThreshold = false;
}