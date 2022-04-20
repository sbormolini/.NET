// See https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example#lang-features for more information

namespace DesignPatterns.ChainOfResponsibility;

// The Handler interface declares a method for building the chain of
// handlers. It also declares a method for executing a request.
public interface IHandler
{
    IHandler SetNext(IHandler handler);

    object Handle(object request);
}
