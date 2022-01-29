using Ardalis.ApiEndpoints;
using Customers.Api.WithApiEndpoints.Models;
using Customers.Api.WithApiEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Api.WithApiEndpoints.Endpoints.Customers;

public class DeleteCustomer
{
    private readonly ICustomersService _customersService;

    public DeleteCustomer(ICustomersService customersService) => _customersService = customersService;
}
