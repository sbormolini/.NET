using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Attributes;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class GetCustomerRequest
{
    [FromRoute(Name = "id")] public Guid Id { get; init; }
}

public class GetCustomer : EndpointBaseAsync.WithRequest<GetCustomerRequest>
                                            .WithActionResult
{
    private readonly ICustomersService _customersService;

    public GetCustomer(ICustomersService customersService) => _customersService = customersService;

    [HttpGet("customers/{id:guid}")]
    [SwaggerOperation(
        Summary = "Gets customer by Id",
        Description = "Gets customer by Id",
        OperationId = "Customer.Get",
        Tags = new[] { "CustomerEndpoint" })]
    public override async Task<ActionResult> HandleAsync(
        [FromMultiSource] GetCustomerRequest request,
        CancellationToken cancellationToken = default)
    {
        var customer = await _customersService.GetByIdAsync(request.Id);
        if (customer is null)
            return NotFound();

        return Ok(customer);
    }
}