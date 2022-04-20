using DesignPatterns.Decorator;


Client client = new();

var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(simple);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
ConcreteDecoratorA decorator1 = new(simple);
ConcreteDecoratorB decorator2 = new(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);
