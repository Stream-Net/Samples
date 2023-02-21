using StreamNet.Consumers;
using StreamNet.Publisher.Infrastructure.Events.Order;

namespace StreamNet.Publisher.Infrastructure.Consumers;

[ConsumerGroup("StreamNet.Tests")]
public class OrderCreatedEventConsumer : Consumer<OrderCreatedEvent>
{
    private new readonly ILogger<Consumer<OrderCreatedEvent>> _logger;

    public OrderCreatedEventConsumer(ILogger<Consumer<OrderCreatedEvent>> logger) : base(logger) 
        => _logger = logger;

    public override Task HandleAsync()
    {
        _logger.LogInformation("Received event {@event}.", Message);
        return Task.CompletedTask;
    }
}