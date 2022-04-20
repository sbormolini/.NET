// See https://refactoring.guru/design-patterns/mediator/csharp/example#lang-features for more information

using DesignPatterns.Mediator;


// The client code.
Component1 component1 = new Component1();
Component2 component2 = new Component2();
new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggets operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();