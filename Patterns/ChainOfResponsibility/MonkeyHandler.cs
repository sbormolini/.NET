// See https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example#lang-features for more information

namespace DesignPatterns.ChainOfResponsibility;

class MonkeyHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "Banana")
        {
            return $"Monkey: I'll eat the {request}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
