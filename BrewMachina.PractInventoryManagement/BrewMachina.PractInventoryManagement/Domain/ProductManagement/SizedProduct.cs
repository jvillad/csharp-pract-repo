using BrewMachina.PractInventoryManagement.Domain.General;

namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public class SizedProduct : Product
{

    public SizedProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : base(id, name, description, price, UnitType.PerSize, maxAmountInStock)
    {
    }
}