using Customers.Api.WithApiEndpoints.Models;

namespace Customers.Api.WithApiEndpoints.Services
{
    public interface ICustomersService
    {
        List<Customer> GetAll();
        Customer? GetById(Guid id);
        bool Create(Customer? customer);
        bool Delete(Guid id);
        bool Update(Customer customer);

        Task<List<Customer?>> GetAllAsync();
        Task<Customer?> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(Customer customer);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(Customer customer);
    }
}