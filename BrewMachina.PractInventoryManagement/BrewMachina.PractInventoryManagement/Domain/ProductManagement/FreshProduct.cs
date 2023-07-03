using BrewMachina.PractInventoryManagement.Domain.General;

namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public class FreshProduct : Product
{
    public DateTime ExpiryDateTime { get; set; }
    public string? StorageInstructions { get; set; }
    
    public FreshProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : base(id, name, description, price, unitType, maxAmountInStock)
    {
    }
}