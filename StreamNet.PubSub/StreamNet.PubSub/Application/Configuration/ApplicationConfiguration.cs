using StreamNet.Publisher.Application.UseCases.PublishEvent;

namespace StreamNet.Publisher.Application.Configuration;

public static class ApplicationConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services)
    {
        services.AddSingleton<IRequestCreateOrder, RequestCreateOrder>();
    }
}