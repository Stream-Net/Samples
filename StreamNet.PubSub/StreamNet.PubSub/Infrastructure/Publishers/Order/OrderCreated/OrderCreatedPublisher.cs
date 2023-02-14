using StreamNet.Producers;
using StreamNet.Publisher.Application.Infrastructure.Publishers.Order.OrderCreated;
using StreamNet.Publisher.Infrastructure.Events.Order;

namespace StreamNet.Publisher.Infrastructure.Publishers.Order.OrderCreated;

public class OrderCreatedPublisher : IOrderCreatedPublisher
{
    private readonly IPublisher _publisher;
    private readonly ILogger<OrderCreatedPublisher> _logger;

    public OrderCreatedPublisher(IPublisher publisher, ILogger<OrderCreatedPublisher> logger)
    {
        _publisher = publisher;
        _logger = logger;
    }

    public async Task PublishOrderCreatedAsync(Domain.Entities.Order order)
    {
        var @event = new OrderCreatedEvent(order.CustomerName, order.OrderValue, order.DeliveryAddress);
        await _publisher.ProduceAsync(@event);
        _logger.LogInformation("Published event {@event} in topic.", @event);
    }
}