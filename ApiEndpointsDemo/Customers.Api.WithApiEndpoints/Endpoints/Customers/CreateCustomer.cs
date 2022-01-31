using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Models;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class CreateCustomer : EndpointBaseAsync.WithRequest<Customer>
                                               .WithActionResult<Customer>
{
    private readonly ICustomersService _customersService;

    public CreateCustomer(ICustomersService customersService) => _customersService = customersService;

    [HttpPost("customers")]
    public override async Task<ActionResult<Customer>> HandleAsync(Customer customer, CancellationToken cancellationToken = default)
    {
        var created = await _customersService.CreateAsync(customer);
        if (!created)
            return BadRequest();

        return Ok(created);
    }
}
