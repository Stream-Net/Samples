namespace StreamNet.Publisher.Application.UseCases.PublishEvent.Input;

public struct RequestCreateOrderInput
{
    public string CustomerName { get; set; }
    public decimal OrderValue { get; set; }
    public string DeliveryAddress { get; set; }
}