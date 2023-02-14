namespace StreamNet.Publisher.Domain.Entities;

public class Order
{
    public Order(string customerName, decimal orderValue, string deliveryAddress)
    {
        CustomerName = customerName;
        OrderValue = orderValue;
        DeliveryAddress = deliveryAddress;
    }

    public string CustomerName { get; }
    public decimal OrderValue { get; }
    public string DeliveryAddress { get; }
}