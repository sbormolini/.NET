// See https://refactoring.guru/design-patterns/visitor/csharp/example#lang-features for more information

using DesignPatterns.Visitor;

List<IComponent> components = new()
{
    new ConcreteComponentA(),
    new ConcreteComponentB()
};

Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
var visitor1 = new ConcreteVisitor1();
Client.ClientCode(components, visitor1);

Console.WriteLine();

Console.WriteLine("It allows the same client code to work with different types of visitors:");
var visitor2 = new ConcreteVisitor2();
Client.ClientCode(components, visitor2);