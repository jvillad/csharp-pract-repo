using System.Text;
using BrewMachina.PractInventoryManagement.Domain.General;

namespace BrewMachina.PractInventoryManagement.Domain.ProductManagement;

public partial class Product
{

    private int _id;
    private string _name = null!;
    private string? _description;
    private int _maxItemsInStock = 0;
    public Price Price { get; set; } = null!;


    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        // example business rules that the name accepts only 50 characters
        set => _name = value.Length > 50 ? value[..50] : value;
    }

    public string? Description
    {
        get => _description;
        set
        {
            if (value == null)
            {
                _description = string.Empty;
            }
            else
            {
                // assuming that business rules indicates a maximum of 250 characters for description
                _description = value.Length > 250 ? value[..250] : value;
            }
        }
    }
    
    public UnitType UnitType { get; set; }
    // private set(internal property): changing the value of AmountInStock outside of the product class is blocked. Read-only property
    public int AmountInStock { get; private set; }
    // private set(internal property): changing the value of IsBelowStockThreshold outside of the product class is blocked. Read-only property
    public bool IsBelowStockThreshold { get; private set; }
    
    // overloading constructor
    public Product(int id) : this(id, string.Empty){}

    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Product(int id, string name, string? description,Price price, UnitType unitType, 
        int maxAmountInStock )
    {
        Id = id;
        Name = name;
        Description = description;
        UnitType = unitType;
        _maxItemsInStock = maxAmountInStock;
        Price = price;
        UpdateLowStock();
    }

    public void UseProduct(int items)
    {
        if (items <= AmountInStock)
        {

            //use the items 
            AmountInStock -= items;
            UpdateLowStock();
            Log($"Amount in stock updated. Now {AmountInStock} items in stock.");
        }
        else
        {
            Log($"Not enough items on stock for {CreateSimpleProductRepresentation()}. {AmountInStock} available but {items} requested.");
        }
    }

    public void IncreaseStock()
    {
        AmountInStock++;
    }

    public void IncreaseStock(int amount)
    {
        int newStock = AmountInStock + AmountInStock;
        if (newStock <= _maxItemsInStock)
        {
            AmountInStock += amount;
        }
        else
        {
            // only store possible items, overstock is not stored
            AmountInStock = _maxItemsInStock;
            Log($"{CreateSimpleProductRepresentation()} stock overflow. {newStock - AmountInStock} item(s) ordered that couldn't be stored.");
        }

        if (AmountInStock > StockThreshold)
        {
            IsBelowStockThreshold = false;
        }
    }


    private void DecreaseStock(int items, string reason)
    {
        if (items <= AmountInStock)
        {
            AmountInStock -= items;
        }
        else
        {
            AmountInStock = 0;
        }
        UpdateLowStock();
        Log(reason);
        
    }

    public string DisplayDetailsShort()
    {
        return $"{_id}. {_name} \n {AmountInStock} items in stock";
    }

    public string DisplayDetailsFull()
    {
        StringBuilder sb = new();
        sb.Append($"{Id} {Name} \n{Description} \n{Price} \n{AmountInStock} item(s) in stock");
        if (IsBelowStockThreshold)
        {
            sb.Append("\n!!Stock Low!!");
        }

        return sb.ToString();
        /*return DisplayDetailsFull("");*/
    }
    public string DisplayDetailsFull(string extraDetails)
    {
        StringBuilder sb = new();
        sb.Append($"{Id} {Name} \n {Description} \n{Price} \n{AmountInStock} item(s) in stock");
        sb.Append(extraDetails);
        if (IsBelowStockThreshold)
        {
            sb.Append("\n!!Stock Low!!");
        }

        return sb.ToString();
    }
}
