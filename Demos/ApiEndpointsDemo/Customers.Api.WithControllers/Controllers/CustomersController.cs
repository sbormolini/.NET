using Customers.Api.WithControllers.Models;
using Customers.Api.WithControllers.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customers.Api.WithControllers.Controllers
{
    [ApiController]
    [Route("[controller]")] //"api/[controller]"
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customerService;

        public CustomersController(ICustomersService customersService) => 
            _customerService = customersService;

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById([FromRoute]Guid id)
        {
            var customer = _customerService.GetById(id);
            if (customer is null)
                return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            var created = _customerService.Create(customer);
            if (!created)
                return BadRequest();
            
            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id:guid}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] Customer updatedCustomer)
        {
            var customer = _customerService.GetById(id);
            if (customer is null)
                return NotFound();

            _customerService.Update(updatedCustomer);
            return Ok(updatedCustomer);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            var deleted = _customerService.Delete(id);
            if (!deleted)
                return NotFound();
           
            return Ok();
        }
    }
}
