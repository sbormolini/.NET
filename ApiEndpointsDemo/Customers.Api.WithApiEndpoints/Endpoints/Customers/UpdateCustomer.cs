using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Attributes;
using Customers.Api.WithApiEndpoints.Models;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class UpdateCustomerRequest
{
    [FromRoute(Name = "id")] public Guid Id { get; init; }
    [FromBody] public Customer UpdatedCustomer { get; set; } = default!;
}

public class UpdateCustomer : EndpointBaseAsync.WithRequest<UpdateCustomerRequest>
                                               .WithActionResult<Customer>
{
    private readonly ICustomersService _customersService;

    public UpdateCustomer(ICustomersService customersService) => _customersService = customersService;

    [HttpPut("customers/{id:guid}")]
    [SwaggerOperation(
        Summary = "Updates customer",
        Description = "Updates customer",
        OperationId = "Customer.Update",
        Tags = new[] { "CustomerEndpoint" })]
    public override async Task<ActionResult<Customer>> HandleAsync(
        [FromMultiSource] UpdateCustomerRequest request, 
        CancellationToken cancellationToken = default)
    {
        var customer = await _customersService.GetByIdAsync(request.Id);
        if (customer is null)
            return NotFound();

        await _customersService.UpdateAsync(request.UpdatedCustomer);
        return Ok(request.UpdatedCustomer);
    }
}