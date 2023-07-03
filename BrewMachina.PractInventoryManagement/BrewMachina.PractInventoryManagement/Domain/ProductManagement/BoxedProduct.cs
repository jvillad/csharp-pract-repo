using System.Text;
using BrewMachina.PractInventoryManagement.Domain.General;

namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public class BoxedProduct : Product
{
    private int _amountPerBox;

    public int AmountPerBox
    {
        get => _amountPerBox;
        set => _amountPerBox = value;
    }
    public BoxedProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : base(id, name, description, price, UnitType.PerBox, maxAmountInStock)
    {
        AmountPerBox = _amountPerBox;
    }

    public string DisplayBoxedProductDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Boxed Product\n");
        sb.Append($"{Id} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");

        if (IsBelowStockThreshold)
        {
            sb.Append("\n!!STOCK LOW!!!");
        }

        return sb.ToString();
    }

    /// <summary>
    ///  Boxed products will always be used per box. When box is open or 1 item is used inside the box, the entire box is considered used.
    /// </summary>
    /// <param name="items"></param>
    public void UseBoxedProduct(int items)
    {
        DecreaseStock(0, "Lorem");
        
        int smallestMultiple = 0;
        int batchSize;

        while (true)
        {
            smallestMultiple++;
            if (smallestMultiple * AmountPerBox > items)
            {
                batchSize = smallestMultiple * AmountPerBox;
                break;
            }
        }
        UseProduct(batchSize);
    }
}