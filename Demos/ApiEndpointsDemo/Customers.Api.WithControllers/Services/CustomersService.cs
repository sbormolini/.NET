﻿using Customers.Api.WithControllers.Models;

namespace Customers.Api.WithControllers.Services;

public class CustomersService : ICustomersService
{
    private readonly Dictionary<Guid, Customer> _customers = new();

    public bool Create(Customer? customer)
    {
        if (customer is null)
            return false;

        _customers[customer.Id] = customer;
        return true;
    }

    public Customer? GetById(Guid id) => _customers.GetValueOrDefault(id);

    public List<Customer> GetAll() => _customers.Values.ToList();

    public bool Update(Customer customer)
    {
        var existingCustomer = GetById(customer.Id);
        if (existingCustomer is null)
            return false;

        _customers[customer.Id] = customer;
        return true;
    }

    public bool Delete(Guid id)
    {
        var existingCustomer = GetById(id);
        if (existingCustomer is null)
            return false;

        _customers.Remove(id);
        return true;
    }
}
