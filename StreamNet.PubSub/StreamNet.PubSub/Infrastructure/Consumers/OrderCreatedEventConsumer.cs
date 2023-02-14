using StreamNet.Consumers;
using StreamNet.Publisher.Infrastructure.Events.Order;

namespace StreamNet.Publisher.Infrastructure.Consumers;

[ConsumerGroup("StreamNet.Tests")]
public class OrderCreatedEventConsumer : Consumer<OrderCreatedEvent>
{
    private readonly ILogger<Consumer<OrderCreatedEvent>> _logger;

    public OrderCreatedEventConsumer(ILogger<Consumer<OrderCreatedEvent>> logger) : base(logger) 
        => _logger = logger;

    public override async Task HandleAsync() 
        => _logger.LogInformation("Received event {@event}.", Message);
}