// Concrete Creators override the factory method in order to change the
// resulting product's type.

// The Product interface declares the operations that all concrete products
// must implement.
public interface IProduct
{
    string Operation();
}
