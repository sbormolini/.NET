// The Creator class declares the factory method that is supposed to return
// an object of a Product class. The Creator's subclasses usually provide
// the implementation of this method.

// Concrete Creators override the factory method in order to change the
// resulting product's type.


// The Product interface declares the operations that all concrete products
// must implement.

// Concrete Products provide various implementations of the Product
// interface.

class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteCreator1.");
        ClientCode(new ConcreteCreator());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCreator2.");
        ClientCode(new ConcreteCreator2());
    }

    // The client code works with an instance of a concrete creator, albeit
    // through its base interface. As long as the client keeps working with
    // the creator via the base interface, you can pass it any creator's
    // subclass.
    public void ClientCode(Creator creator)
    {
        // ...
        Console.WriteLine("Client: I'm not aware of the creator's class," + "but it still works.\n" + creator.SomeOperation());
        // ...
    }
}
