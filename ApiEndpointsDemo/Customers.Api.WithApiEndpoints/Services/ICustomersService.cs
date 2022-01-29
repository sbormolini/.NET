using Customers.Api.WithApiEndpoints.Models;

namespace Customers.Api.WithApiEndpoints.Services
{
    public interface ICustomersService
    {
        bool Create(Customer? customer);
        bool Delete(Guid id);
        List<Customer> GetAll();
        Customer? GetById(Guid id);
        bool Update(Customer customer);
        Task<List<Customer>> GetAllAsync();
        Task CreateAsync(Customer customer);
    }
}