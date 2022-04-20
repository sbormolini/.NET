// See https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example#lang-features for more information

namespace DesignPatterns.ChainOfResponsibility;

class DogHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "MeatBall")
        {
            return $"Dog: I'll eat the {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}
