using StreamNet.Publisher.Application.Infrastructure.Publishers.Order.OrderCreated;
using StreamNet.Publisher.Infrastructure.Consumers;
using StreamNet.Publisher.Infrastructure.Events.Order;
using StreamNet.Publisher.Infrastructure.Publishers.Order.OrderCreated;

namespace StreamNet.Publisher.Infrastructure.Configuration;

public static class InfrastructureConfiguration
{
    public static void AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddProducer();
        services.AddConsumer<OrderCreatedEventConsumer, OrderCreatedEvent>();
        services.AddSingleton<IOrderCreatedPublisher, OrderCreatedPublisher>();
    }
}