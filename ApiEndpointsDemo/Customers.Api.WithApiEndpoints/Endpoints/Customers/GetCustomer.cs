using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Models;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class GetCustomer
{
    private readonly ICustomersService _customersService;

    public GetCustomer(ICustomersService customersService) => _customersService = customersService;
}
