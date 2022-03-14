using Customers.Api.WithControllers.Models;

namespace Customers.Api.WithControllers.Services
{
    public interface ICustomersService
    {
        bool Create(Customer? customer);
        bool Delete(Guid id);
        List<Customer> GetAll();
        Customer? GetById(Guid id);
        bool Update(Customer customer);
    }
}