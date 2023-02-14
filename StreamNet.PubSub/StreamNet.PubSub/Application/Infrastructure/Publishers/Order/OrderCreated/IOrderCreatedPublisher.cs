namespace StreamNet.Publisher.Application.Infrastructure.Publishers.Order.OrderCreated;

public interface IOrderCreatedPublisher
{
    Task PublishOrderCreatedAsync(Domain.Entities.Order order);
}