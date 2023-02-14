using StreamNet.Publisher.Application.UseCases.PublishEvent.Input;

namespace StreamNet.Publisher.Application.UseCases.PublishEvent;

public interface IRequestCreateOrder
{
    Task ExecuteAsync(RequestCreateOrderInput createOrderEvent);
}