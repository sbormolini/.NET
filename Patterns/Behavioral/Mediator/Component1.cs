// See https://refactoring.guru/design-patterns/mediator/csharp/example#lang-features for more information

namespace DesignPatterns.Mediator;

// Concrete Components implement various functionality. They don't depend on
// other components. They also don't depend on any concrete mediator
// classes.
class Component1 : BaseComponent
{
    public void DoA()
    {
        Console.WriteLine("Component 1 does A.");
        _mediator.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Component 1 does B.");
        _mediator.Notify(this, "B");
    }
}
