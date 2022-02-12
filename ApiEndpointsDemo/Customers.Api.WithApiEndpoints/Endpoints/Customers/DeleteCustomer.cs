using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Attributes;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class DeleteCustomerRequest
{
    [FromRoute(Name = "id")] public Guid Id { get; init; }
}

public class DeleteCustomer : EndpointBaseAsync.WithRequest<DeleteCustomerRequest>
                                               .WithActionResult
{
    private readonly ICustomersService _customersService;

    public DeleteCustomer(ICustomersService customersService) => _customersService = customersService;

    [HttpDelete("customers/{id:guid}")]
    [SwaggerOperation(
        Summary = "Deletes customer",
        Description = "Deletes customer",
        OperationId = "Customer.Delete",
        Tags = new[] { "CustomerEndpoint" })]
    public override async Task<ActionResult> HandleAsync(
        [FromMultiSource] DeleteCustomerRequest request, 
        CancellationToken cancellationToken = default)
    {
        var deleted = await _customersService.DeleteAsync(request.Id);
        if (!deleted)
            return NotFound();

        return Ok();
    }
}
