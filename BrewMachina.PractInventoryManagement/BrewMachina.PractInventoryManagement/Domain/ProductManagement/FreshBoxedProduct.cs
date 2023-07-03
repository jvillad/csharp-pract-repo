using BrewMachina.PractInventoryManagement.Domain.General;

namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public class FreshBoxedProduct : BoxedProduct
{
    public FreshBoxedProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : base(id, name, description, price, unitType, maxAmountInStock)
    {
    }

    public void UseFreshBoxedProduct(int items)
    {
        UseBoxedProduct(3);
    }
}