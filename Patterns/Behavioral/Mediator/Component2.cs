// See https://refactoring.guru/design-patterns/mediator/csharp/example#lang-features for more information

namespace DesignPatterns.Mediator;
class Component2 : BaseComponent
{
    public void DoC()
    {
        Console.WriteLine("Component 2 does C.");
        _mediator.Notify(this, "C");
    }

    public void DoD()
    {
        Console.WriteLine("Component 2 does D.");
        _mediator.Notify(this, "D");
    }
}