namespace StreamNet.Publisher.Infrastructure.Events.Order;

public class OrderCreatedEvent
{
    public OrderCreatedEvent(string customerName, decimal orderValue, string deliveryAddress)
    {
        CustomerName = customerName;
        OrderValue = orderValue;
        DeliveryAddress = deliveryAddress;
    }
    
    public string CustomerName { get; }
    public decimal OrderValue { get; }
    public string DeliveryAddress { get; }
}