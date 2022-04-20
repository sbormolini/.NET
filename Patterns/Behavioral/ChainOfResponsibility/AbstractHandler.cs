// See https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example#lang-features for more information

namespace DesignPatterns.ChainOfResponsibility;

// The default chaining behavior can be implemented inside a base handler
// class.
abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;

        // Returning a handler from here will let us link handlers in a
        // convenient way like this:
        // monkey.SetNext(squirrel).SetNext(dog);
        return handler;
    }

    public virtual object? Handle(object request)
    {
        if (_nextHandler is not null)
        {
            return _nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}
