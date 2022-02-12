using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Models;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class CreateCustomer : EndpointBaseAsync.WithRequest<Customer>
                                               .WithActionResult<Customer>
{
    private readonly ICustomersService _customersService;

    public CreateCustomer(ICustomersService customersService) => _customersService = customersService;

    [HttpPost("customers")]
    [SwaggerOperation(
        Summary = "Creates customer",
        Description = "Creates customer",
        OperationId = "Customer.Create",
        Tags = new[] { "CustomerEndpoint" })]
    public override async Task<ActionResult<Customer>> HandleAsync(Customer customer, CancellationToken cancellationToken = default)
    {
        var created = await _customersService.CreateAsync(customer);
        if (!created)
            return BadRequest();

        return Ok(created);
    }
}
