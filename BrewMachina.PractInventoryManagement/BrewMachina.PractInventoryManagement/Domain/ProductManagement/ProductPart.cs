namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public partial class Product
{
    public static int StockThreshold = 5;

    public static void ChangeStockThreshold(int newStockThreshold)
    {
        if (newStockThreshold > 0)
            StockThreshold = newStockThreshold;
    }

    public void UpdateLowStock()
    {
        // defaulting and fix to 10(temp)
        if (AmountInStock < StockThreshold)
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