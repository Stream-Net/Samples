using System.Net;
using Microsoft.AspNetCore.Mvc;
using StreamNet.Publisher.Application.UseCases.PublishEvent;
using StreamNet.Publisher.Application.UseCases.PublishEvent.Input;

namespace StreamNet.Publisher.Api.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class OrderController: ControllerBase
{
    private readonly IRequestCreateOrder _useCase;
    private readonly ILogger<OrderController> _logger;

    public OrderController(IRequestCreateOrder useCase, ILogger<OrderController> logger)
    {
        _useCase = useCase;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> PostOrder([FromBody] RequestCreateOrderInput input)
    {
        try
        {
            await _useCase.ExecuteAsync(input);
            return Accepted();
        }
        catch (Exception e)
        {
            _logger.LogError(e,"A unexpected error occured in {method}.", nameof(PostOrder));
            return StatusCode((int)HttpStatusCode.InternalServerError, $"A unexpected error occured.");
        }
    }
}