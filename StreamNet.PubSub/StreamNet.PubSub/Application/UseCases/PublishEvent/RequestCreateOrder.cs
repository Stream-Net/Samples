using StreamNet.Publisher.Application.Infrastructure.Publishers.Order.OrderCreated;
using StreamNet.Publisher.Application.UseCases.PublishEvent.Input;
using StreamNet.Publisher.Domain.Entities;

namespace StreamNet.Publisher.Application.UseCases.PublishEvent;

public class RequestCreateOrder : IRequestCreateOrder
{
    private readonly ILogger<RequestCreateOrder> _logger;
    private readonly IOrderCreatedPublisher _orderCreatedPublisher;

    public RequestCreateOrder(ILogger<RequestCreateOrder> logger, IOrderCreatedPublisher orderCreatedPublisher)
    {
        _logger = logger;
        _orderCreatedPublisher = orderCreatedPublisher;
    }
    
    public async Task ExecuteAsync(RequestCreateOrderInput createOrderEvent)
    {
        var orderEntity = new Order(createOrderEvent.CustomerName, createOrderEvent.OrderValue,
            createOrderEvent.DeliveryAddress);
        
        await _orderCreatedPublisher.PublishOrderCreatedAsync(orderEntity);
    }
}