namespace Customers.Api.WithApiEndpoints.Models;

public record Customer
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }
}
