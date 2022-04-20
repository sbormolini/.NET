// See https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example#lang-features for more information

namespace DesignPatterns.ChainOfResponsibility;

class SquirrelHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "Nut")
        {
            return $"Squirrel: I'll eat the {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
