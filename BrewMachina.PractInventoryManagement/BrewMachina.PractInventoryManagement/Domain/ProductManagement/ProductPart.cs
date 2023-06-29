namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public partial class Product
{
    private void UpdateLowStock()
    {
        // defaulting and fix to 10(temp)
        if (AmountInStock < 10)
        {
            IsBelowStockThreshold = true;
        }
    }
    
    // utility method
    private void Log(string message)
    {
        Console.WriteLine((message));
    }
    
    // utility method
    private string CreateSimpleProductRepresentation()
    {
        return $"Product {_id} ({_name})";
    }
}