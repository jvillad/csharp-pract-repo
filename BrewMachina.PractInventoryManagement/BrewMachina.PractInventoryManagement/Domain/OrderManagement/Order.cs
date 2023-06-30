using System.Text;

namespace BrewMachina.PractInventoryManagement.Domain.OrderManagement;

public class Order
{
    public int Id { get; private set; }
    public DateTime OrderFulfilmentDate { get; private set; }
    public List<OrderItem> OrderItems { get; }
    public bool Fulfilled { get; set; } = false;

    public Order()
    {
        // random id value
        Id = new Random().Next(999999);
        
        int numberofSeconds = new Random().Next(100);
        OrderFulfilmentDate = DateTime.Now.AddSeconds(numberofSeconds);

        OrderItems = new List<OrderItem>();
    }

    public string ShowOrderDetails()
    {
        StringBuilder orderDetails = new StringBuilder();
        orderDetails.AppendLine($"Order ID: {Id}");
        orderDetails.AppendLine($"Order fulfilment date:{OrderFulfilmentDate.ToShortDateString()}");
        if (OrderItems != null)
        {
            foreach (OrderItem item in OrderItems)
            {
                orderDetails.AppendLine($"{item.ProductId}. {item.ProductName}: {item.AmountOrdered}");
            }
        }

        return orderDetails.ToString();
    }
}