using Customers.Api.WithApiEndpoints.Models;

namespace Customers.Api.WithApiEndpoints.Services;

public class CustomersService : ICustomersService
{
    private readonly Dictionary<Guid, Customer> _customers = new();

    public Customer? GetById(Guid id) => _customers.GetValueOrDefault(id);

    public List<Customer> GetAll() => _customers.Values.ToList();

    public bool Create(Customer? customer)
    {
        if (customer is null)
            return false;

        _customers[customer.Id] = customer;
        return true;
    }

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

    public Task<List<Customer?>> GetAllAsync() => Task.FromResult(_customers.Values.ToList());
    
    public Task<Customer?> GetByIdAsync(Guid id) => Task.FromResult(_customers?.GetValueOrDefault(id));

    public Task<bool> CreateAsync(Customer customer)
    {
        if (customer is null)
            return Task.FromResult(false);

        _customers[customer.Id] = customer;
        return Task.FromResult(true);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        var existingCustomer = GetById(id);
        if (existingCustomer is null)
            return Task.FromResult(false);

        _customers.Remove(id);
        return Task.FromResult(true);
    }

    public Task<bool> UpdateAsync(Customer customer)
    {
        var existingCustomer = GetById(customer.Id);
        if (existingCustomer is null)
            return Task.FromResult(false);

        _customers[customer.Id] = customer;
        return Task.FromResult(true);
    }
}
