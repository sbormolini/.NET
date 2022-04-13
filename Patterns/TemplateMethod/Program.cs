
// See https://refactoring.guru/design-patterns/template-method/csharp/example#lang-features for more information

using DesignPatterns.TemplateMethod;

// The Abstract Class defines a template method that contains a skeleton of
// some algorithm, composed of calls to (usually) abstract primitive
// operations.
//
// Concrete subclasses should implement these operations, but leave the
// template method itself intact.

Console.WriteLine("Same client code can work with different subclasses:");
Client.ClientCode(new ConcreteClass1());

Console.Write("\n");

Console.WriteLine("Same client code can work with different subclasses:");
Client.ClientCode(new ConcreteClass2());