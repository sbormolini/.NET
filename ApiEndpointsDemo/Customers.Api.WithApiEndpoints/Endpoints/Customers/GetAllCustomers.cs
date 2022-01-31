using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Models;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class GetAllCustomers : EndpointBaseAsync.WithoutRequest
                                                .WithActionResult<List<Customer>>
{
    private readonly ICustomersService _customersService;

    public GetAllCustomers(ICustomersService customersService) => _customersService = customersService;

    [HttpGet("customers")]
    public override async Task<ActionResult<List<Customer>>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var customers = await _customersService.GetAllAsync();
        return Ok(customers);
    }
}
