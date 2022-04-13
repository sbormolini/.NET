// See https://refactoring.guru/design-patterns/template-method/csharp/example#lang-features for more information

namespace DesignPatterns.TemplateMethod;

// The Abstract Class defines a template method that contains a skeleton of
// some algorithm, composed of calls to (usually) abstract primitive
// operations.
//
// Concrete subclasses should implement these operations, but leave the
// template method itself intact.

// Concrete classes have to implement all abstract operations of the base
// class. They can also override some operations with a default
// implementation.
// Usually, concrete classes override only a fraction of base class'
// operations.
class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperations1() =>
        Console.WriteLine("ConcreteClass2 says: Implemented Operation1");

    protected override void RequiredOperation2() =>
        Console.WriteLine("ConcreteClass2 says: Implemented Operation2");

    protected override void Hook1() =>
        Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
}
